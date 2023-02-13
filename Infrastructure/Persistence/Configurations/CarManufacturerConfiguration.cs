using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entity;

namespace Infrastructure.Persistence.Configurations;

public class CarManufacturerConfiguration : IEntityTypeConfiguration<CarManufacturer>
{
    public void Configure(EntityTypeBuilder<CarManufacturer> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.Id).IsUnique();
        builder.Property(x => x.C_Name).HasMaxLength(50);
    }
}
