using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace ProgrammingServiceProxies.Movie
{
    public interface IMovieProxy
    {
        Task<string> GetMovieNameById(int id);
    }

    public class MovieProxy : IMovieProxy
    {
        private readonly ApiUrls _apiUrls;

        private readonly HttpClient _httpClient;

        public MovieProxy(IOptions<ApiUrls> apiUrls, HttpClient httpClient)
        {
            _apiUrls = apiUrls.Value;
            _httpClient = httpClient;
        }

        public async Task<string> GetMovieNameById(int id)
        {
            string dir = _apiUrls.MovieUrl + "/" + "movies" + "/" + "names" + "/" + id.ToString();
            var request = await _httpClient.GetAsync(dir);
            var result = request.Content.ReadAsStringAsync().Result;
            request.EnsureSuccessStatusCode();
            return result;
        }
    }
}
