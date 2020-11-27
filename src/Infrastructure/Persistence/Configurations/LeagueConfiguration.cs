using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class LeagueConfiguration : IEntityTypeConfiguration<League>
    {
        public void Configure(EntityTypeBuilder<League> builder)
        {
            builder.Property(l => l.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasOne(l => l.Country)
                .WithMany(c => c.Leagues)
                .HasForeignKey(l => l.CountryId);
        }
    }
}
