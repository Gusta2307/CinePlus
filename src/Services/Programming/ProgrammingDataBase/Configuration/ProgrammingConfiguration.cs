using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammingDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingDataBase.Configuration
{
    public class ProgrammingConfiguration
    {
        public ProgrammingConfiguration(EntityTypeBuilder<Programming> entityBuilder)
        {
            entityBuilder.HasKey(prog => new { prog.ID_M, prog.ID_Cinema, prog.DataHour_P }); //declarar la llave de la tabla
            entityBuilder.Property(prog => prog.Ticket_Price).IsRequired();
            entityBuilder.Property(prog => prog.Pay_Points).IsRequired();
            entityBuilder.HasData(programming);
        }

        public List<Programming> programming = new List<Programming>()
        {
            new Programming
            {
                ID_M = 1,
                ID_Cinema = 3,
                DataHour_P = "14-06-2021 12:40",
                Ticket_Price = 15,
                Pay_Points = 8
            },

            new Programming
            {
                ID_M = 8,
                ID_Cinema = 1,
                DataHour_P = "14-06-2021 10:30",
                Ticket_Price = 10,
                Pay_Points = 5
            },

            new Programming
            {
                ID_M = 2,
                ID_Cinema = 3,
                DataHour_P = "14-06-2021 10:30",
                Ticket_Price = 10,
                Pay_Points = 5
            },

            new Programming
            {
                ID_M = 4,
                ID_Cinema = 3,
                DataHour_P = "14-06-2021 08:30",
                Ticket_Price = 7.20f,
                Pay_Points = 2
            },

            new Programming
            {
                ID_M = 5,
                ID_Cinema = 9,
                DataHour_P = "15-06-2021 20:00",
                Ticket_Price = 21,
                Pay_Points = 11
            },

            new Programming
            {
                ID_M = 10,
                ID_Cinema = 5,
                DataHour_P = "16-06-2021 09:40",
                Ticket_Price = 8.40f,
                Pay_Points = 4
            },

            new Programming
            {
                ID_M = 10,
                ID_Cinema = 7,
                DataHour_P = "16-06-2021 09:40",
                Ticket_Price = 12,
                Pay_Points = 6
            },

            new Programming
            {
                ID_M = 8,
                ID_Cinema = 5,
                DataHour_P = "17-06-2021 2:20",
                Ticket_Price = 12.5f,
                Pay_Points = 4
            },

            new Programming
            {
                ID_M = 3,
                ID_Cinema = 6,
                DataHour_P = "17-06-2021 2:20",
                Ticket_Price = 25,
                Pay_Points = 13
            },

            new Programming
            {
                ID_M = 7,
                ID_Cinema = 7,
                DataHour_P = "19-06-2021 11:30",
                Ticket_Price = 10,
                Pay_Points = 5
            },
        };
    }
}
