using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PunctuationServiceEventHandler.Command;
using PunctuationServiceQueries;
using PunctuationServiceQueries.DTO;
using ServiceCommonCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PunctuationApi.Controllers
{
    [ApiController]
    [Route("punctuations")]
    public class PunctuacionMovieController : ControllerBase
    {
        private readonly ILogger<PunctuacionMovieController> _logger;

        private readonly IPunctuationMovieQueryService _punctuationServiceQuery;

        private readonly IMediator _mediator;

        public PunctuacionMovieController(ILogger<PunctuacionMovieController> logger, IPunctuationMovieQueryService punctuationServiceQuery, IMediator mediator)
        {
            _logger = logger;
            _punctuationServiceQuery = punctuationServiceQuery;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<DataCollection<PunctuationDTO>> GetAll()
        {
            return await _punctuationServiceQuery.GetAllAsync();
        }

        [HttpGet("morelike")]
        public List<string> GetMovieMoreLike()
        {
            return _punctuationServiceQuery.GetMoreLikeAsync();
        }

        [HttpGet("points")]
        public async Task<int> Get(int id_m, string email)
        {
            var result = await _punctuationServiceQuery.GetAsync(id_m, email);
            return result.Points;
        }

        [HttpPost]
        public async Task<ActionResult> Create(PunctuationMovieCreateCommand notification)
        {
            await _mediator.Publish(notification);
            return Ok();
        }
    }

}
