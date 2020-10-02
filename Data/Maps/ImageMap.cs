using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padronize.Models;

namespace Padronize.Data.Maps
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.ToTable("Image");
            builder.HasKey(x => x.id);
            builder.Property(x => x.x).IsRequired().HasColumnType("double(10,2)");
            builder.Property(x => x.y).IsRequired().HasColumnType("double(10,2)");
            builder.Property(x => x.text).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
        }
    }
}