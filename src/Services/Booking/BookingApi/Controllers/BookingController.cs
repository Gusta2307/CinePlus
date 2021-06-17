using BookingServiceEventHandler.Command;
using BookingServicesQueries;
using BookingServicesQueries.DTO;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApi.Controllers
{
    [ApiController]
    [Route("bookings")]
    public class BookingController : ControllerBase
    {
        private readonly ILogger<BookingController> _logger;

        private readonly IBookingQueryService _bookingServiceQuery;

        private readonly IMediator _mediator;

        public BookingController(ILogger<BookingController> logger, IBookingQueryService bookingServiceQuery, IMediator mediator)
        {
            _logger = logger;
            _bookingServiceQuery = bookingServiceQuery;
            _mediator = mediator;
        }

        [HttpGet("moreview")]
        public List<string> GetMovieMoreView()
        {
            return _bookingServiceQuery.GetMoreViewAsync();
        }

        //Ver reserva realizada
        [HttpGet]
        public async Task<BookingDTO> Get(int id_m, int id_c, string id_dh, string email_user)
        {
            var result = await _bookingServiceQuery.GetAsync(id_m, id_c, id_dh, email_user);
            return result;
        }

        //Añadir Reserva
        [HttpPost]
        public async Task<IActionResult> Create(BookingCreateCommand notification)
        {
            await _mediator.Publish(notification);
            return Ok();
        }

        //Dado el codigo de la compra, verificar compra
        [HttpPost("checkbuy")]
        public async Task<IActionResult> CheckBuy(BookingCheckBuyBookingCommand request)
        {
            var result = await _mediator.Send(request);

            if (result.Message == "Pay")
            {
                await UpdateIsPaid(new BookingUpdateCommand
                {
                    ID_Cinema = result.ID_Cinema,
                    ID_M = result.ID_M,
                    DataHour_P = result.DataHour_P,
                    Email_User = result.Email_User
                });

                return Ok("La reserva ha sido pagada satisfactoriamente");
            }
            return Ok(result.Message);
        }

        [HttpGet("totalmoney/{buy_cod}")]
        public async Task<float> GetTotalMoney(string buy_cod)
        {
            return await _bookingServiceQuery.GetTotalMoney(buy_cod);
        }

        //Actualizar reserva a "Pagado"
        public async Task<IActionResult> UpdateIsPaid(BookingUpdateCommand notification)
        {
            await _mediator.Publish(notification);
            return NoContent();
        }

        //Borrar una reserva
        [HttpDelete]
        public async Task<IActionResult> Delete(BookingDeleteCommand notification)
        {
            await _mediator.Publish(notification);
            return Ok();
        }

        [HttpGet("getEstadistic")]
        public float ByTypeEstadistic(string type, int p)
        {
            float result = 0;

            if (type == "anual")
            {
                result = _bookingServiceQuery.GetAnnualEstadistic(p);
            }
            else if (type == "mensual")
            {
                result = _bookingServiceQuery.GetMonthlyEstadistic(p);
            }
            else //diario
            {
                result = _bookingServiceQuery.GetDailyEstadistic(p);
            }

            return result;
        }
    }
}
