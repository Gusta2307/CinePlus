using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaServiceEventHandler.Command
{
    public enum Action
    {
        Sum,
        Rest
    }

    public class CinemaUpdateCountTicketsCommand : INotification
    {
        public int ID_Cinema { get; set; }

        public int Update_Count_Armchair { get; set; } //cantidad a descontar o aumentar

        public Action Operation { get; set; }
    }
}
