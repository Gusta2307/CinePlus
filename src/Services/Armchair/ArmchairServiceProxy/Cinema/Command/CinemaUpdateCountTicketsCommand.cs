using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmchairServiceProxy.Cinema.Command
{
    public enum Action
    {
        Aumentar,
        Disminuir
    }

    public class CinemaUpdateCountTicketsCommand
    {
        public int ID_Cinema { get; set; }

        public int Update_Count_Armchair { get; set; } //cantidad a descontar o aumentar

        public Action Operation { get; set; }
    }
}
