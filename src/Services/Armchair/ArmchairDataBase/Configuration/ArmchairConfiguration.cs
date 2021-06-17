using ArmchairDomain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmchairDataBase.Configuration
{
    public class ArmchairConfiguration
    {
        public ArmchairConfiguration(EntityTypeBuilder<Armchair> entityBuilder)
        {
            entityBuilder.HasKey(k => new { k.ID_Cinema, k.Num_Armchair }); //declarar la llave de la tabla
            entityBuilder.Property(armchair => armchair.Reserved).IsRequired();
            entityBuilder.HasData(CreateDefaultArmchairs());
        }

        private List<Armchair> CreateDefaultArmchairs()
        {
            var random = new Random();
            int[] cinemas = { 100, 108, 99, 57, 128, 133, 98, 99, 83, 99 };
            List<Armchair> armchairs = new List<Armchair>();

            for (var i = 1; i <= 10; i++)
            {
                int count_armchair = cinemas[i - 1];
                for (var j = 1; j <= count_armchair; j++)
                    armchairs.Add(new Armchair
                    {
                        ID_Cinema = i,
                        Num_Armchair = j,
                        Reserved = "NO"
                    });
            }

            return armchairs;
        }
    }
}
