using Core.Entities;
using Core.Enumerations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.Property(p => p.Foot)
                .HasConversion(f => f.Id,
                    v => Foot.FromValue<Foot>(v));

            builder.Property(p => p.Position)
                .HasConversion(p => p.Id,
                    v => Position.FromValue<Position>(v));
        }
    }
}
