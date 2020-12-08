using Api.Common.Mappings;
using ApplicationCore.Entities;

namespace Api.Features.Stadiums.Queries
{
    public class StadiumDto : IDto<Stadium>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int YearBuilt { get; set; }
    }
}
