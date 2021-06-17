using ArmchairServicesQueries;
using ArmchairServicesQueries.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceCommonCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using ArmchairServiceEventHandler.Command;

namespace ArmchairApi.Controllers
{
    [ApiController]
    [Route("armchairs")]
    public class ArmchairController : ControllerBase
    {
        private readonly ILogger<ArmchairController> _logger;

        private readonly IArmchairQueryService _armchairQueryService;

        private readonly IMediator _mediator;

        public ArmchairController(ILogger<ArmchairController> logger, IArmchairQueryService armchairQueryService, IMediator mediator)
        {
            _logger = logger;
            _armchairQueryService = armchairQueryService;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<DataCollection<ArmchairDTO>> AsigArmchairs(int id_selected_cinema, int count_tickets)
        {
            var collection = await _armchairQueryService.AsignArmchairsAsync(id_selected_cinema, count_tickets);

            if (collection.Count < count_tickets)
            {
                BadRequest("La cantidad de butacas que requiere no esta disponible");
                return null;
            }

            return collection;
        }

        [HttpGet("{id_selected_cinema}")]
        public async Task<DataCollection<ArmchairDTO>> GetNoReservedArmchairs(int id_selected_cinema)
        {
            return await _armchairQueryService.GetAllArmchairAsync(id_selected_cinema);
        }

        //Actualiza las butacas reservadas, y genera y retorna un codigo para la compra realizada
        [HttpPut]
        public async Task<ActionResult> UpdateReservedArmchair(ArmchairUpdateReservedCommand notification)
        {
            var result = await _mediator.Send(notification);

            if (!result.Succeeded)
                return BadRequest("Error a la hora de actualizar las butacas reservadas");

            return Ok(result);
        }
    }
}
