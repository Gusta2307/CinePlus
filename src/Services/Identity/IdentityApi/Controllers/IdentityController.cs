using IdentityDomain;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserServiceEventHandler.Command;

namespace IdentityApi.Controllers
{
    [ApiController]
    [Route("identity")]
    public class IdentityController : ControllerBase
    {
        private readonly ILogger<IdentityController> _logger;

        private readonly SignInManager<User> _signInManager;

        private readonly IMediator _mediator;

        public IdentityController(ILogger<IdentityController> logger, SignInManager<User> signInManager, IMediator mediator)
        {
            _logger = logger;
            _signInManager = signInManager;
            _mediator = mediator;
        }

        public IdentityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserCreateCommand command)
        {
            //falta lo del role
            if (command.Password == command.Confirm_Password)
            {
                if (ModelState.IsValid)
                {
                    var result = await _mediator.Send(command);

                    if (!result.Succeeded)
                    {
                        return BadRequest(result.Errors);
                    }

                    return Ok();
                }
            }
            return BadRequest("Password and Confirm_Password are diferents");
        }

        [HttpPost("authentication")]
        public async Task<IActionResult> Authentication(UserLoginCommand command)
        {
            if (ModelState.IsValid)
            {
                var result = await _mediator.Send(command);

                if (!result.Succeeded)
                {
                    return BadRequest("Access denied");
                }

                return Ok(result);
            }

            return BadRequest();
        }

        [HttpPost("employees")]
        public async Task<IActionResult> AddEmployee(AdminCreateEmployeeCommand command)
        {
            if (command.Password == command.Confirm_Password)
            {
                if (ModelState.IsValid)
                {
                    var result = await _mediator.Send(command);

                    if (!result.Succeeded)
                    {
                        return BadRequest(result.Errors);
                    }

                    return Ok();
                }
            }
            return BadRequest("Password and Confirm_Password are diferents");
        }

        [HttpDelete("employees")]
        public async Task<IActionResult> AddEmployee(AdminDeleteEmployeeCommand command)
        {
            if (ModelState.IsValid)
            {
                var result = await _mediator.Send(command);

                if (!result.Succeeded)
                {
                    return BadRequest(result.Errors);
                }

                return Ok();
            }
            return BadRequest("Password and Confirm_Password are diferents");
        }
    }
}
