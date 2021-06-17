using BookingDataBase;
using BookingDomain;
using BookingServiceEventHandler.Command;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BookingServiceEventHandler
{
    public class BookingCreateEventHadler : INotificationHandler<BookingCreateCommand>
    {
        private readonly ApplicationDbContext _context;

        public BookingCreateEventHadler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(BookingCreateCommand notification, CancellationToken cancellationToken)
        {
            int percentDiscountChildrenRetired = (3 * notification.Ticket_Price) / 10;
            int percentDiscountStudentsFEU = (5 * notification.Ticket_Price) / 10;
            int percentSpectatorDay = (2 * notification.Ticket_Price) / 10;

            int moneySpectatorDay;
            int moneyTotal;
            int moneyTotalByPoinst = notification.Total_Tickets * notification.Pay_Points;
            if (notification.IsSpectatorDay)
            {
                moneySpectatorDay = (notification.Ticket_Price - percentSpectatorDay) * notification.Total_Tickets;
                moneyTotal = moneySpectatorDay;
            }
            else
            {
                int moneyChildren = (notification.Ticket_Price - percentDiscountChildrenRetired) * notification.Total_Tickets_Childrens;
                int moneyRetired = (notification.Ticket_Price - percentDiscountChildrenRetired) * notification.Total_Tickets_Retired;
                int moneyStudentsFEU = (notification.Ticket_Price - percentDiscountStudentsFEU) * notification.Total_TicketsStudentsFEU;
                int moneyRest = (notification.Ticket_Price) * (notification.Total_Tickets - notification.Total_Tickets_Childrens - notification.Total_Tickets_Retired - notification.Total_TicketsStudentsFEU);
                moneyTotal = moneyChildren + moneyRetired + moneyStudentsFEU + moneyRest;
            }

            await _context.AddAsync(new Booking
            {
                ID_M = notification.ID_M,
                ID_Cinema = notification.ID_Cinema,
                DataHour_P = notification.DataHour_P,
                Email_User = notification.Email_User,
                Selected_Armchairs = notification.Selected_Armchairs,
                Buy_Cod = notification.Buy_Cod,
                Total_Tickets = notification.Total_Tickets,
                Total_Tickets_Childrens = notification.Total_Tickets_Childrens,
                Total_Tickets_Retired = notification.Total_Tickets_Retired,
                Total_TicketsStudentsFEU = notification.Total_TicketsStudentsFEU,
                Total_Money = moneyTotal,
                Total_Money_By_Points = moneyTotalByPoinst,
                DataHour_Booking = DateTime.Now.ToString(), //fecha actual
                IsPaid = "NO"
            }) ;

            await _context.SaveChangesAsync();
        }
    }
}
