using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace UserServiceEventHandler.Command
{
    public enum Action
    {
        Sum,
        Rest
    }

    public class UserUpdatePointsCommand : INotification
    {
        public string Email_User { get; set; }

        public int Count_Poinst { get; set; }

        public Action Operation { get; set; }
    }
}
