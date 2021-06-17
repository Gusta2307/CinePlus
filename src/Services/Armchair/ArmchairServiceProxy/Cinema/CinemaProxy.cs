using ArmchairServiceProxy.Cinema.Command;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ArmchairServiceProxy.Cinema
{
    public interface ICinemaProxy
    {
        Task<string> UpdateCountArmchair(CinemaUpdateCountTicketsCommand command);
    }

    public class CinemaProxy : ICinemaProxy
    {
        private readonly ApiUrls _apiUrls;

        private readonly HttpClient _httpClient;

        public CinemaProxy(IOptions<ApiUrls> apiUrls, HttpClient httpClient)
        {
            _apiUrls = apiUrls.Value;
            _httpClient = httpClient;
        }

        public Task<string> UpdateCountArmchair(CinemaUpdateCountTicketsCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
