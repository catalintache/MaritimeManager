using Microsoft.EntityFrameworkCore;
using MyApp.Domain.Entities;

namespace MyApp.Infrastructure.Data {
  public class AppDbContext : DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> opts): base(opts) {}
    public DbSet<Country> Countries => Set<Country>();
    public DbSet<Port> Ports => Set<Port>();
    public DbSet<Ship> Ships => Set<Ship>();
    public DbSet<Voyage> Voyages => Set<Voyage>();

    protected override void OnModelCreating(ModelBuilder mb) {
      mb.Entity<Voyage>()
        .HasOne(v => v.DeparturePort).WithMany().OnDelete(DeleteBehavior.Restrict);
      mb.Entity<Voyage>()
        .HasOne(v => v.ArrivalPort).WithMany().OnDelete(DeleteBehavior.Restrict);
    }
  }
}