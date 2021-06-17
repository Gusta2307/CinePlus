using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingServiceEventHandler.Command
{
    public class ProgrammingUpdateCinemaCommand : INotification
    {
        public int ID_Cinema { get; set; }

        public int ID_M { get; set; }

        public string DataHour_P { get; set; }

        public int New_ID_Cinema { get; set; } //nuevo id de cinema
    }
}
