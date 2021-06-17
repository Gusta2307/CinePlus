using BookingDataBase;
using BookingProxies.Movie;
using BookingServicesQueries.DTO;
using ServiceCommonMapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using ServiceCommonCollection;
using System.Linq;
using System;
using ServiceCommonPapping;
using System.Collections.Generic;

namespace BookingServicesQueries
{
    public interface IBookingQueryService
    {
        Task<BookingDTO> GetAsync(int id_m, int id_c, string id_dh, string id_email);

        List<string> GetMoreViewAsync();

        Task<float> GetTotalMoney(string buy_cod);

        float GetAnnualEstadistic(int year);

        float GetMonthlyEstadistic(int year);

        float GetDailyEstadistic(int year);
    }

    public class BookingQueryService : IBookingQueryService
    {
        private readonly ApplicationDbContext _context;

        private readonly IMovieProxy _movieProxy;

        private readonly ILogger<BookingQueryService> _logger;

        public BookingQueryService(ApplicationDbContext context, ILogger<BookingQueryService> logger, IMovieProxy movieProxy)
        {
            _context = context;
            _logger = logger;
            _movieProxy = movieProxy;
        }

        
        public async Task<BookingDTO> GetAsync(int id_m, int id_c, string id_dh, string id_email)
        {
            var item = (await _context.Bookings.SingleAsync(x => x.ID_M == id_m && x.ID_Cinema == id_c && x.DataHour_P == id_dh && x.Email_User == id_email)).MapTo<BookingDTO>();
            string name_m = _movieProxy.GetMovieById(id_m).Result; //nombre de la pelicula
            return new BookingDTO
            {
                Name_P = name_m,
                ID_Cinema = id_c,
                ID_M = id_m,
                DataHour_P = id_dh,
                Email_User = id_email,
                Selected_Armchairs = item.Selected_Armchairs,
                Buy_Cod = item.Buy_Cod,
                Total_Tickets = item.Total_Tickets,
                Total_Tickets_Childrens = item.Total_Tickets_Childrens,
                Total_Tickets_Retired = item.Total_Tickets_Retired,
                Total_TicketsStudentsFEU = item.Total_TicketsStudentsFEU,
                Total_Money = item.Total_Money,
                Total_Money_By_Points = item.Total_Money_By_Points,
                DataHour_Booking = item.DataHour_Booking,
                IsPaid = item.IsPaid,
            };
        }

        //Estadistica anual
        public float GetAnnualEstadistic(int year)
        {
            float sum_ticket = 0;
            float sum_money = 0;

            var items = _context.Bookings
                .Where(x => DateTime.Parse(x.DataHour_Booking).Year == year)
                .GroupBy(m => m.ID_M)
                .Select(g => new { total_t = g.Sum(x => x.Total_Tickets), total_money = g.Sum(x => x.Total_Money) });

            foreach (var elemt in items)
            {
                sum_ticket = elemt.total_t;
                sum_money = elemt.total_money;
            }

            return sum_money * sum_ticket;
        }

        //Estadistica Diaria
        public float GetDailyEstadistic(int day)
        {
            float sum_ticket = 0;
            float sum_money = 0;

            var items = _context.Bookings
                .Where(x => DateTime.Parse(x.DataHour_Booking).Day == day)
                .GroupBy(m => m.ID_M)
                .Select(g => new { total_t = g.Sum(x => x.Total_Tickets), total_money = g.Sum(x => x.Total_Money) });

            foreach (var elemt in items)
            {
                sum_ticket = elemt.total_t;
                sum_money = elemt.total_money;
            }

            return sum_money * sum_ticket;
        }

        public float GetMonthlyEstadistic(int month)
        {
            float sum_ticket = 0;
            float sum_money = 0;

            var items = _context.Bookings
                .Where(x => DateTime.Parse(x.DataHour_Booking).Month == month)
                .GroupBy(m => m.ID_M)
                .Select(g => new { total_t = g.Sum(x => x.Total_Tickets), total_money = g.Sum(x => x.Total_Money) });

            foreach (var elemt in items)
            {
                sum_ticket = elemt.total_t;
                sum_money = elemt.total_money;
            }

            return sum_money * sum_ticket;
        }

        //Muestra las 10 peliculas mas vistas por el publico
        public List<string> GetMoreViewAsync()
        {
            var items = _context.Bookings
                .GroupBy(m => m.ID_M)
                .Select(g => new { id = g.Key, total_t = g.Sum(x => x.Total_Tickets) })
                .OrderByDescending(g => g.total_t)
                .Take(10);

            List<string> movies = new List<string>();

            foreach (var movie in items)
            {
                string name_m = _movieProxy.GetMovieById(movie.id).Result;
                movies.Add(name_m);
            }
            return movies;
        }

        public async Task<float> GetTotalMoney(string buy_cod)
        {
            var item = (await _context.Bookings.SingleAsync(x => x.Buy_Cod == buy_cod)).MapTo<BookingDTO>();
            return item.Total_Money; //monto total
        }

        
    }
}
