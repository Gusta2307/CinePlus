using IdentityDomain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace IdentityDataBase.Configuration
{
    public class UserConfiguration
    {
        public UserConfiguration(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Name_LastName).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.Password).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.Role);
            entityBuilder.Property(x => x.IsAssociated);
            entityBuilder.Property(x => x.Points);
        }
    }
}
