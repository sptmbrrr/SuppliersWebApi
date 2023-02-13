using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entity;

namespace Infrastructure.Persistence.Configurations;

public class PartLevelConfiguration : IEntityTypeConfiguration<PartLevel>
{
    public void Configure(EntityTypeBuilder<PartLevel> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.Id).IsUnique();
        builder.Property(x => x.C_Description).HasMaxLength(50);
    }
}
