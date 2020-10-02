using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padronize.Models;

namespace Padronize.Data.Maps
{
    public class ProjectMap : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project");
            builder.HasKey(x => x.id);
            builder.Property(x => x.title).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(x => x.description).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.LastUpdateDate).IsRequired();
        }
    }
}