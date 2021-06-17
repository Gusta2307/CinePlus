using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServiceEventHandler.Reponse
{
    public class BookingResult
    {
        public string Message { get; set; }

        public int ID_Cinema { get; set; }

        public int ID_M { get; set; }

        public string DataHour_P { get; set; }

        public string Email_User { get; set; }
    }
}
