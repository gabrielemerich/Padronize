using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padronize.Models;

namespace Padronize.Data.Maps
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.id);
            builder.Property(x => x.login).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(x => x.password).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
        }
    }
}