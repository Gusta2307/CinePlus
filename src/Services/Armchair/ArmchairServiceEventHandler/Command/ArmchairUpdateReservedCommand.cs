using ArmchairServiceEventHandler.Reponse;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmchairServiceEventHandler.Command
{
    public class ArmchairUpdateReservedCommand : IRequest<UpdateReponse>
    {
        public int ID_Cinema { get; set; }

        public IEnumerable<int> Num_ArmchairsIEnu { get; set; }
    }
}
