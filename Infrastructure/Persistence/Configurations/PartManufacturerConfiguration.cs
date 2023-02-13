using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entity;

namespace Infrastructure.Persistence.Configurations;

public class PartManufacturerConfiguration : IEntityTypeConfiguration<PartManufacturer>
{
    public void Configure(EntityTypeBuilder<PartManufacturer> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.Id).IsUnique();
        builder.Property(x => x.C_Name).HasMaxLength(50);
    }
}
