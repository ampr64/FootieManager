using Core.Entities;
using Core.Enums;
using Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infrastructure.Persistence.Configurations
{
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.Property(p => p.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.LastName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.Foot)
                .HasConversion(
                    v => v.ToString(),
                    v => (Foot)Enum.Parse(typeof(Foot), v));

            builder.Property(p => p.Position)
                .HasConversion(
                    v => v.ToString(),
                    v => (Position)Enum.Parse(typeof(Position), v));

            builder.Property(c => c.Salary)
                .HasPrecision(15, 2);

            builder.Property(c => c.MarketValue)
                .HasPrecision(15, 2);

            builder.HasOne(p => p.Club)
                .WithMany(c => c.Squad)
                .HasForeignKey(p => p.ClubId);
        }
    }
}
