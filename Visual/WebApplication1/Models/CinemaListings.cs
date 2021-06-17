using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieDomain;

namespace WebApplication1.Models
{
    public class CinemaListings
    {
        public int ID_Cinema { get; set; }

        public Movie current_movie { get; set; }

        public string DataHour_P { get; set; }

        public int Ticket_Price { get; set; }

        public int Pay_Points { get; set; }
    }
}
