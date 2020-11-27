using Core.Enumerations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.HasKey(c => c.Value);

            builder.Property(c => c.Value)
                .HasColumnName("Id");

            builder.Property(c => c.Value)
                .ValueGeneratedNever();
        }
    }
}
