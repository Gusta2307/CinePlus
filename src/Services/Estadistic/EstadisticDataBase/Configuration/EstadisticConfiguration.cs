using EstadisticDomain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadisticDataBase.Configuration
{
    public class EstadisticConfiguration
    {
        public EstadisticConfiguration(EntityTypeBuilder<Estadistic> entityBuilder)
        {
            entityBuilder.HasKey(estadistic => estadistic.ID_E); //declarar el id de cinema: ID_Cinema
            entityBuilder.Property(estadistic => estadistic.Name_E).IsRequired().HasMaxLength(100);
            entityBuilder.HasData(estadistics);
        }

        public List<Estadistic> estadistics = new List<Estadistic>()
        {
            new Estadistic
            {
                ID_E = 1,
                Name_E = "Anual"
            },

            new Estadistic
            {
                ID_E = 2,
                Name_E = "Mensual"
            },

            new Estadistic
            {
                ID_E = 3,
                Name_E = "Diaria"
            },
        };
    }
}
