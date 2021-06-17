using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GangwayServiceEventHandler.Reponse;
using MediatR;

namespace GangwayServiceEventHandler.Command
{
    public class GangwayDeleteCommand : IRequest<GangwayResult>
    {
        public string Email { get; set; }

        public string Buy_Cod { get; set; }

        public string Credit_Card { get; set; }
    }
}
