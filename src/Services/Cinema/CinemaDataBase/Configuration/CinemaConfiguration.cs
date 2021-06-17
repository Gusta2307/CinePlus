using CinemaDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaDataBase.Configuration
{
    public class CinemaConfiguration
    {
        public CinemaConfiguration(EntityTypeBuilder<Cinema> entityBuilder)
        {
            entityBuilder.HasKey(cinema => cinema.ID_Cinema); //declarar el id de cinema: ID_Cinema
            entityBuilder.Property(cinema => cinema.Count_Armchair).IsRequired();
            entityBuilder.HasData(CreateDefaultCinemas());
        }

        public List<Cinema> CreateDefaultCinemas()
        {
            List<Cinema> cinemas = new List<Cinema>()
            {
                new Cinema
                {
                    ID_Cinema = 1,
                    Count_Armchair = 100
                },

                new Cinema
                {
                    ID_Cinema = 2,
                    Count_Armchair = 108
                },

                new Cinema
                {
                    ID_Cinema = 3,
                    Count_Armchair = 99
                },

                new Cinema
                {
                    ID_Cinema = 4,
                    Count_Armchair = 57
                },

                new Cinema
                {
                    ID_Cinema = 5,
                    Count_Armchair = 128
                },

                new Cinema
                {
                    ID_Cinema = 6,
                    Count_Armchair = 133
                },

                new Cinema
                {
                    ID_Cinema = 7,
                    Count_Armchair = 98
                },

                new Cinema
                {
                    ID_Cinema = 8,
                    Count_Armchair = 99
                },

                new Cinema
                {
                    ID_Cinema = 9,
                    Count_Armchair = 83
                },

                new Cinema
                {
                    ID_Cinema = 10,
                    Count_Armchair = 99
                },
            };

            return cinemas;
        }
    }
}
