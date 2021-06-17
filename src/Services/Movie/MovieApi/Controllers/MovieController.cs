using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieServiceEventHandler.Command;
using MovieServicesQueries;
using MovieServicesQueries.DTO;
using ServiceCommonCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApi.Controllers
{
    [ApiController]
    [Route("movies")]
    public class MovieController : ControllerBase
    {
        private readonly ILogger<MovieController> _logger;

        private readonly IMovieQueryService _movieServiceQuery;

        private readonly IMediator _mediator;

        public MovieController(ILogger<MovieController> logger, IMovieQueryService movieServiceQuery, IMediator mediator)
        {
            _logger = logger;
            _movieServiceQuery = movieServiceQuery;
            _mediator = mediator;
        }


        public MovieController(IMovieQueryService movieServiceQuery, IMediator mediator)
        {
            _movieServiceQuery = movieServiceQuery;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<DataCollection<MovieDTO>> GetAll()
        {
            return await _movieServiceQuery.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<MovieDTO> Get(int id)
        {
            var result = await _movieServiceQuery.GetAsync(id);
            return result;
        }

        [HttpGet("names/{id}")]
        public string GetNameMovie(int id)
        {
            string result = _movieServiceQuery.GetName(id);
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> Create(MovieCreateCommand notification)
        {
            await _mediator.Publish(notification);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id, MovieDeleteCommand notification)
        {
            notification.ID_M = id;
            await _mediator.Publish(notification);
            return Ok();
        }
    }
}
