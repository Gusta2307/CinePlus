using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PunctuationDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunctuationDataBase.Configuration
{
    public class PunctuationMovieConfiguration
    {
        public PunctuationMovieConfiguration(EntityTypeBuilder<Punctuation> entityBuilder)
        {
            entityBuilder.HasKey(punctuation => new { punctuation.ID_M, punctuation.Email }); //declarar el id de cinema: ID_Cinema
            entityBuilder.Property(punctuation => punctuation.Points).IsRequired();
            entityBuilder.HasData(punctuations);
        }

        public List<Punctuation> punctuations = new List<Punctuation>()
        {
            new Punctuation
            {
                ID_M = 7,
                Email = "grettelhernandezmatcom@gmail.com",
                Points = 5
            },

            new Punctuation
            {
                ID_M = 2,
                Email = "melissa.sanchez@gmail.com",
                Points = 4
            },

            new Punctuation
            {
                ID_M = 2,
                Email ="grettelhernandezmatcom@gmail.com",
                Points = 5
            },

            new Punctuation
            {
                ID_M = 3,
                Email = "melissa.sanchez@gmail.com",
                Points = 3
            }
        };
    }

}
