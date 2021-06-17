using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunctuationServiceEventHandler.Command
{
    public class PunctuationMovieCreateCommand : INotification
    {
        public int ID_M { get; set; }

        public string Email { get; set; }

        public int Points { get; set; }
    }

}
