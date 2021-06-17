using GangwayDomain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangawayDataBase.Configuration
{
    public class UserPayConfiguration
    {
        public UserPayConfiguration(EntityTypeBuilder<UserPay> entityBuilder)
        {
            entityBuilder.HasKey(usepay => usepay.Email); //declarar el id de cinema: ID_Cinema
            entityBuilder.Property(userpay => userpay.Credit_Card).IsRequired();
            entityBuilder.HasData(userpays);
        }

        public List<UserPay> userpays = new List<UserPay>()
        {
            new UserPay
            {
                Email = "grettelhernandezmatcom@gmail.com",
                Credit_Card = "9225-9598-0560-9882"
            }
        };
    }
}
