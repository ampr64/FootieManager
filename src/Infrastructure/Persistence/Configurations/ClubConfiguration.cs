using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class ClubConfiguration : IEntityTypeConfiguration<Club>
    {
        public void Configure(EntityTypeBuilder<Club> builder)
        {
            builder.Property(c => c.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.President)
                .HasMaxLength(50);

            builder.HasOne(c => c.League)
                .WithMany(l => l.Clubs)
                .HasForeignKey(c => c.LeagueId);

            builder.HasOne(c => c.Stadium)
                .WithMany(s => s.Clubs)
                .HasForeignKey(c => c.StadiumId);
        }
    }
}
