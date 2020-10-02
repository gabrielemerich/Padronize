using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padronize.Models;

namespace Padronize.Data.Maps
{
    public class ApplicationMap : IEntityTypeConfiguration<Application>
    {
        public void Configure(EntityTypeBuilder<Application> builder)
        {
            builder.ToTable("Application");
            builder.HasKey(x => x.id);
            builder.Property(x => x.name).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(x => x.description).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
        }
    }
}