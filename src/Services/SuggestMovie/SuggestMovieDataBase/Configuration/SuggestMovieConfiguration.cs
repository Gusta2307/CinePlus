using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuggestMovieDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuggestMovieDataBase.Configuration
{
    public class SuggestMovieConfiguration
    {
        public SuggestMovieConfiguration(EntityTypeBuilder<SuggestMovie> entityBuilder)
        {
            entityBuilder.HasKey(sugg => sugg.Type_S); //declarar el id: ID_SM
            entityBuilder.Property(sugg => sugg.Selected).IsRequired();
            entityBuilder.HasData(suggests);
        }

        public List<SuggestMovie> suggests = new List<SuggestMovie>()
        {
            new SuggestMovie
            {
                Type_S = "mas vista",
                Selected = 1
            },
            new SuggestMovie
            {
                Type_S = "mas gustada",
                Selected = 0
            },
        };
    }
}
