using GangwayServiceEventHandler.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GangwayApi.Controllers
{
    [ApiController]
    [Route("gangway")]
    public class GangwayController : ControllerBase
    {
        private readonly ILogger<GangwayController> _logger;

        private readonly IMediator _mediator;

        public GangwayController(ILogger<GangwayController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> Create(GangwayCreateCommand notification)
        {
            await _mediator.Publish(notification);
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<ActionResult> Delete(GangwayDeleteCommand request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpPost("discount")]
        public void Discount(int total_money, string credit_card)
        {
            //descontar el monto {total_money} de la tarjeta {credit_card}
            return;
        }
    }
}
