using Microsoft.EntityFrameworkCore;
using Domain.Entity;
namespace Infrastructure.Persistence;

public class DataContext : DbContext
{
    public DbSet<PartManufacturer> PartManufacturers { get; set; }
    public DbSet<CarManufacturer> CarManufacturers { get; set; }
    public DbSet<PartLevel> PartLevels { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<PartType> PartTypes { get; set; }
    public DbSet<Part> Parts { get; set; }
    public DbSet<Car> Cars { get; set; }

    public DataContext()
    {
        //Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Database=SuppliersDB;Password=admin;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Part).Assembly);
    }
}
