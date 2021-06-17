using Microsoft.AspNetCore.Mvc;
using UserServiceEventHandler.Command;
using IdentityApi.Controllers;
using MediatR;
using IdentityDomain;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<IdentityController> _logger;

        private readonly SignInManager<User> _signInManager;

        private readonly IMediator _mediator;
     
        public AccountController(ILogger<IdentityController> logger, SignInManager<User> signInManager, IMediator mediator)
        {
            _logger = logger;
            _signInManager = signInManager;
            _mediator = mediator;
        }
        
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(UserLoginCommand model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "Datos incorrectos, intente de nuevo.";
                return View(model);
            }
            var result = new IdentityController(_logger, _signInManager,_mediator).Authentication(model);
            var isAurh = User.Identity.IsAuthenticated;
            if (Request.HttpContext.Response.StatusCode == 200)
                return View("../Home/Index");
            return View();

        }

        [HttpPost]
        public ActionResult Register(UserCreateCommand model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "Datos incorrectos, intente de nuevo.";
                return View(model);
            }
            var result = new IdentityController(_mediator).Create(model);
            if (Request.HttpContext.Response.StatusCode == 200)
                return View("../Home/Index");
            return View();
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

    }
}
