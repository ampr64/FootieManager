using ApplicationCore.Entities;
using ApplicationCore.Enumerations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.IsoCode)
                .HasMaxLength(2);

            builder.HasOne<Continent>()
                .WithMany(c => c.Countries)
                .HasForeignKey(d => d.ContinentId);
        }
    }
}
