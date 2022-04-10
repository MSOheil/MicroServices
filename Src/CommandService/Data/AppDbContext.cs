using CommandService.models;
using CommandService.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Command> Commands { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Platform>().HasKey(a => a.Id);
            modelBuilder.Entity<Command>().HasKey(a => a.Id);
            modelBuilder.Entity<Platform>().HasMany(a => a.Commands)
                .WithOne(a => a.Platform)
                .HasForeignKey(a => a.PlatfomrId);

            modelBuilder.Entity<Command>().HasOne(a => a.Platform).WithMany(a => a.Commands)
                .HasForeignKey(a => a.PlatfomrId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
