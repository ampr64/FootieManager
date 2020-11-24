using Core.Enumerations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class ContinentConfiguration : IEntityTypeConfiguration<Continent>
    {
        public void Configure(EntityTypeBuilder<Continent> builder)
        {
            builder.HasKey(c => c.Value);

            builder.Property(c => c.Value)
                .HasColumnName("Id");

            builder.Property(c => c.Value)
                .HasDefaultValue(1)
                .ValueGeneratedNever();
        }
    }
}
