using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProgrammingServiceEventHandler.Command;
using ProgrammingServicesQueries;
using ProgrammingServicesQueries.DTO;
using ServiceCommonCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammingApi.Controllers
{
    [ApiController]
    [Route("programmings")]
    public class ProgrammingController : ControllerBase
    {
        private readonly ILogger<ProgrammingController> _logger;

        private readonly IProgrammingQueryService _progServiceQuery;

        private readonly IMediator _mediator;

        public ProgrammingController(ILogger<ProgrammingController> logger, IProgrammingQueryService progServiceQuery, IMediator mediator)
        {
            _logger = logger;
            _progServiceQuery = progServiceQuery;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<DataCollection<ProgrammingDTO>> GetProgramming()
        {
            return await _progServiceQuery.GetAllAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Create(ProgrammingCreateCommand notification)
        {
            await _mediator.Publish(notification);
            return Ok();
        }

        [HttpPut("updateMovie")]
        public async Task<ActionResult> UpdateMovie(ProgrammingUpdateMovieCommand notification)
        {
            await _mediator.Publish(notification);
            return Ok();
        }

        [HttpPut("updateCinema")]
        public async Task<ActionResult> UpdateCinema(ProgrammingUpdateCinemaCommand notification)
        {
            await _mediator.Publish(notification);
            return Ok();
        }

        [HttpPut("updateDate")]
        public async Task<ActionResult> UpdateDate(ProgrammingUpdateDateCommand notification)
        {
            await _mediator.Publish(notification);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(ProgrammingDeleteCommand notification)
        {
            await _mediator.Publish(notification);
            return Ok();
        }
    }
}
