using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class ClubConfiguration : IEntityTypeConfiguration<Club>
    {
        public void Configure(EntityTypeBuilder<Club> builder)
        {
            builder.HasOne(c => c.Coach)
                .WithOne(c => c.Club)
                .HasForeignKey<Coach>(c => c.ClubId);

            builder.HasOne(c => c.Stadium)
                .WithOne(s => s.Club)
                .HasForeignKey<Stadium>(s => s.ClubId);
        }
    }
}
