using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceCommonCollection;
using SuggestMovieServiceEventHandler.Command;
using SuggestMovieServicesQueries;
using SuggestMovieServicesQueries.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuggestMovieApi.Controllers
{
    [ApiController]
    [Route("suggmovies")]
    public class SuggestMovieController : ControllerBase
    {
        private readonly ILogger<SuggestMovieController> _logger;

        private readonly ISuggestMovieQueryService _suggMovieQuery;

        private readonly IMediator _mediator;

        public SuggestMovieController(ILogger<SuggestMovieController> logger, ISuggestMovieQueryService suggMovieQuery, IMediator mediator = null)
        {
            _logger = logger;
            _suggMovieQuery = suggMovieQuery;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<DataCollection<SuggestMovieDTO>> GetAll()
        {
            return await _suggMovieQuery.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<SuggestMovieDTO> Get(string id)
        {
            return await _suggMovieQuery.GetAsync(id);
        }

        //Devuelve el criterio seleccionado por el administrador
        [HttpGet("selected")]
        public async Task<SuggestMovieDTO> GetSelectedAsync()
        {
            return await _suggMovieQuery.GetSelectedAsync();
        }

        //Actualiza el criterio seleccionado
        [HttpPut]
        public async Task<ActionResult> UpdateDate(SuggestMovieUpdateCommand notification)
        {
            await _mediator.Publish(notification);
            return Ok();
        }
    }
}
