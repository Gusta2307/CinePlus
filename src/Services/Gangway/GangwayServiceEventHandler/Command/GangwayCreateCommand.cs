using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GangwayServiceEventHandler.Command
{
    public class GangwayCreateCommand : INotification
    {
        public string Email { get; set; }

        public string Credit_Card { get; set; }
    }
}
