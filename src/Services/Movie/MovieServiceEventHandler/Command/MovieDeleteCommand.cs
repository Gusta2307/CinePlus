using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieServiceEventHandler.Command
{
    public class MovieDeleteCommand : INotification
    {
        public int ID_M { get; set; }
    }
}
