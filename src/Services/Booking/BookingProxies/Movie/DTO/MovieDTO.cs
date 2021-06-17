using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProxies.Movie.DTO
{
    public class MovieDTO
    {
        public int ID_M { get; set; }

        public string Name_P { get; set; }

        public string Synopsis { get; set; }

        public string Genre { get; set; }

        public string Director { get; set; }

        public int Duration { get; set; }

        public string Photo { get; set; }
    }
}
