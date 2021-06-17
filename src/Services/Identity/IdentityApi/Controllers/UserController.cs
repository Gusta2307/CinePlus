using IdentityServicesQueries;
using IdentityServicesQueries.DTO;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceCommonCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserServiceEventHandler.Command;

namespace IdentityApi.Controllers
{
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly IUserQueryService _userQueryService;

        private readonly ILogger<UserController> _logger;

        private readonly IMediator _mediator;

        public UserController(ILogger<UserController> logger, IMediator mediator, IUserQueryService userQueryService)
        {
            _logger = logger;
            _mediator = mediator;
            _userQueryService = userQueryService;
        }

        [HttpGet]
        public async Task<DataCollection<UserDTO>> GetAll()
        {
            return await _userQueryService.GetAllAsync();
        }

        //Devuelve los datos de un usuario (Se usa para obtener los puntos de un asociado tambien)
        [HttpGet("{id}")]
        public async Task<UserDTO> Get(string id)
        {
            return await _userQueryService.GetAsync(id);
        }

        //Actualiza la cantidad de puntos de un usuario
        [HttpPut]
        public async Task<ActionResult> UpdateCountPoints(UserUpdatePointsCommand notification)
        {
            await _mediator.Publish(notification);
            return NoContent();
        }

        //Comprobar si un usuario es u asociado
        [HttpGet("isassociated")]
        public bool IsAssociated(string email_user)
        {
            return _userQueryService.IsAssociated(email_user);
        }
    }
}
