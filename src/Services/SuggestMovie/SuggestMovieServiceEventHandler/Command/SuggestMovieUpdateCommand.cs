using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuggestMovieServiceEventHandler.Command
{
    public class SuggestMovieUpdateCommand : INotification
    {
        public string Type_S { get; set; }
    }
}
