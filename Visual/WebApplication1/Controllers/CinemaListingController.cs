using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
using MediatR;
//using ProgServicesQueries;
//using ProgServicesQueries.DTO;
using ServiceCommonCollection;
using UserServiceEventHandler.Command;
using IdentityApi.Controllers;
using IdentityDomain;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using ProgrammingApi.Controllers;
using ProgrammingServicesQueries;
using MovieDomain;
using MovieServicesQueries;
using MovieApi.Controllers;


namespace WebApplication1.Controllers
{
    public class CinemaListingsController : Controller
    {
        private readonly ILogger<ProgrammingController> _loggerP;
        //private readonly ILogger<MovieApi.Controllers.MovieController> _loggerM;
        private readonly IProgrammingQueryService _progServiceQuery;
        //private readonly IMovieQueryService _movieQueryService;

        private readonly IMediator _mediator;
        public CinemaListingsController(ILogger<ProgrammingController> logger, IProgrammingQueryService progServiceQuery, IMediator mediator)//, IMovieQueryService movieQueryService)
        {
            _loggerP = logger;
            _progServiceQuery = progServiceQuery;
            //_movieQueryService = movieQueryService;
            _mediator = mediator;
        }

      
        // GET: CinemaListings
        public ActionResult Index()
        {
            var listing = new ProgrammingController(_loggerP, _progServiceQuery, _mediator).GetProgramming().Result;
            return View(listing);
        }

        public ActionResult MovieView(int id)
        {
            //var movie = new MovieApi.Controllers.MovieController(_movieQueryService, _mediator).Get(id);
            //return View(movie);
            return View();
        }

        public ActionResult CinemaListingsForm()
        {
            return View();
        }

        public ActionResult Save()
        {
            return View();
        }
    }
}