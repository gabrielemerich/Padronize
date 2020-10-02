using Microsoft.EntityFrameworkCore;
using Padronize.Data.Maps;
using Padronize.Models;

namespace Padronize.Data
{
    public class StoreDataContext : DbContext
    {
        public DbSet<Project> Project { get; set; }
        public DbSet<Application> Application { get; set; }
        public DbSet<Standart> Standart { get; set; }
        public DbSet<Image> Image { get; set; }

        public StoreDataContext(DbContextOptions<StoreDataContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Project>(new ProjectMap().Configure);
            builder.Entity<Application>(new ApplicationMap().Configure);
            builder.Entity<Standart>(new StandartMap().Configure);
            builder.Entity<Image>(new ImageMap().Configure);
            builder.Entity<User>(new UserMap().Configure);

            builder.Entity<UserProject>()
           .HasKey(t => new { t.UserId, t.ProjectId });

            builder.Entity<UserProject>()
                .HasOne(pt => pt.user)
                .WithMany(p => p.UserProjects)
                .HasForeignKey(pt => pt.UserId);

            builder.Entity<UserProject>()
                .HasOne(pt => pt.Project)
                .WithMany(t => t.UserProjects)
                .HasForeignKey(pt => pt.ProjectId);
        }
    }
}