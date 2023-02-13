using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entity;

namespace Infrastructure.Persistence.Configurations;

public class PartTypeConfiguration : IEntityTypeConfiguration<PartType>
{
    public void Configure(EntityTypeBuilder<PartType> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.Id).IsUnique();
        builder.Property(x => x.C_Description).HasMaxLength(50);
    }
}
