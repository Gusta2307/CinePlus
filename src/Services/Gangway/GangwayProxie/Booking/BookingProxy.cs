using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GangwayProxie.Booking
{
    public interface IBookingProxy
    {
        Task<string> GetTotalMoneyById(string buy_cod);
    }
    public class BookingProxy : IBookingProxy
    {
        private readonly ApiUrls _apiUrls;

        private readonly HttpClient _httpClient;

        public BookingProxy(IOptions<ApiUrls> apiUrls, HttpClient httpClient)
        {
            _apiUrls = apiUrls.Value;
            _httpClient = httpClient;
        }

        public async Task<string> GetTotalMoneyById(string buy_cod)
        {
            string dir = _apiUrls.BookingUrl + "/" + "bookings" + "/" + "totalmoney" + "/" + buy_cod;
            var request = await _httpClient.GetAsync(dir);
            var result = request.Content.ReadAsStringAsync().Result;
            request.EnsureSuccessStatusCode();
            return result;
        }
    }
}
