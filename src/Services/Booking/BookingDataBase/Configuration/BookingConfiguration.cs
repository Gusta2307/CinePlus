using BookingDomain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingDataBase.Configuration
{
    public class BookingConfiguration
    {
        public BookingConfiguration(EntityTypeBuilder<Booking> entityBuilder)
        {
            entityBuilder.HasKey(booking => new { booking.ID_M, booking.ID_Cinema, booking.DataHour_P, booking.Email_User }); //declarar la llave de la tabla
            entityBuilder.Property(booking => booking.Selected_Armchairs).IsRequired();
            entityBuilder.Property(booking => booking.Buy_Cod).IsRequired();
            entityBuilder.Property(booking => booking.Total_Tickets).IsRequired();
            entityBuilder.Property(booking => booking.Total_Tickets_Childrens).IsRequired();
            entityBuilder.Property(booking => booking.Total_Tickets_Retired).IsRequired();
            entityBuilder.Property(booking => booking.Total_TicketsStudentsFEU).IsRequired();
            entityBuilder.Property(booking => booking.Total_Money).IsRequired();
            entityBuilder.Property(booking => booking.Total_Money_By_Points).IsRequired();
            entityBuilder.Property(booking => booking.DataHour_Booking).IsRequired();
            entityBuilder.Property(booking => booking.IsPaid).IsRequired();
        }
    }
}
