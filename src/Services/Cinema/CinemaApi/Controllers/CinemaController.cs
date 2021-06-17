using CinemaServiceEventHandler.Command;
using CinemaServicesQuery;
using CinemaServicesQuery.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceCommonCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CinemaApi.Controllers
{
    [ApiController]
    [Route("cinemas")]
    public class CinemaController : ControllerBase
    {
        private readonly ILogger<CinemaController> _logger;

        private readonly ICinemaQueryService _cinemaQueryService;

        private readonly IMediator _mediator;

        public CinemaController(ILogger<CinemaController> logger, ICinemaQueryService cinemaQueryService, IMediator mediator)
        {
            _logger = logger;
            _cinemaQueryService = cinemaQueryService;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<DataCollection<CinemaDTO>> GetAll()
        {
            return await _cinemaQueryService.GetAllAsync();
        }

        //Determina si la sala seleccionada por el usuario esta disponible para la cantidad de entradas que comprara
        [HttpGet("availableCinema")]
        public async Task<bool> AvailableCinema(int id_selected_movie, int count_tickets)
        {
            var item = await _cinemaQueryService.GetAsync(id_selected_movie);
            var count_armchair = item.Count_Armchair;
            return count_tickets <= count_armchair;
        }

        //Actualiza la cantidad de butacas
        [HttpPut]
        public async Task<ActionResult> UpdateCountArmchairs(CinemaUpdateCountTicketsCommand notification)
        {
            await _mediator.Publish(notification);
            return NoContent();
        }
    }
}
