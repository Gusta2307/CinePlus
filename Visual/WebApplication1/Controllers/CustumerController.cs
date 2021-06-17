using Microsoft.AspNetCore.Mvc;
using UserServiceEventHandler.Command;
using IdentityApi.Controllers;
using MediatR;
using IdentityDomain;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
///using System.Web.Security;
using System;

namespace WebApplication1.Controllers
{
    public class CustumerController : Controller
    {

        private readonly ILogger<IdentityController> _logger;

        private readonly SignInManager<User> _signInManager;

        private readonly IMediator _mediator;

        public CustumerController(ILogger<IdentityController> logger, SignInManager<User> signInManager, IMediator mediator)
        {
            _logger = logger;
            _signInManager = signInManager;
            _mediator = mediator;
        }

        public ActionResult Register()
        {
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
            var ll = result.Result;
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
