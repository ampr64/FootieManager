using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Extensions
{
    public static class EntityTypeBuilderExtensions
    {
        public static PropertyBuilder<decimal> HasPrecision(this PropertyBuilder<decimal> property, byte precision, byte scale)
        {
            property.HasColumnType($"decimal({precision},{scale})");

            return property;
        }

        public static PropertyBuilder<decimal?> HasPrecision(this PropertyBuilder<decimal?> property, byte precision, byte scale)
        {
            property.HasColumnType($"decimal({precision},{scale})");

            return property;
        }
    }
}
