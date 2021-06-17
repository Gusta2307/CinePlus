using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieServicesQueries;
//using MovieServicesQueries;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IMovieQueryService _movieServiceQuery;


        //public HomeController(ILogger<HomeController> logger, IMovieQueryService movieServiceQuery)
        //{
        //    _logger = logger;
        //    _movieServiceQuery = movieServiceQuery;
        //}

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> PrivacyAsync()
        {
            return View();
        }

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
