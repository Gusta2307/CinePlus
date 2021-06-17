using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieDomain;
//using MovieServicesQueries;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
//using MovieDomain;

namespace WebApplication1.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult Index()
        {
            var movie = new Movie()
            {
                ID_M = 1,
                Name_P = "Shrek I",
                Synopsis = "Shrek es un ogro verde, gruñón y altamente territorial que ama la soledad.",
                Genre = "Animación",
                Director = "Vicky Jenson",
                Duration = 90,
                Photo = "https://images.moviesanywhere.com/5948f139cd669fb5984d2c782e7678be/99cedd1f-ae78-4026-a3e8-b79840b71cbc.jpg"
            };

            return View(movie);
        }

        public ActionResult Save()
        {
            return View();
        }

        public ActionResult MovieForm()
        {
            return View();
        }
    }
}
