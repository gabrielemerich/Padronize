using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padronize.Models;

namespace Padronize.Data.Maps
{
    public class StandartMap : IEntityTypeConfiguration<Standart>
    {
        public void Configure(EntityTypeBuilder<Standart> builder)
        {
            builder.ToTable("Standart");
            builder.HasKey(x => x.id);
            builder.Property(x => x.title).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(x => x.description).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(x => x.code_example).IsRequired().HasMaxLength(1024).HasColumnType("varchar(1024)");
        }
    }
}