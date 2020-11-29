using Api.Common.Mappings;
using Api.Features.Countries.Queries;
using AutoMapper;
using Core.Enumerations;
using System.Collections.Generic;

namespace Api.Features.Continents
{
    public class ContinentDto : IDto<Continent>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<CountryDto> Countries { get; set; }

        public void Map(Profile profile)
        {
            profile.CreateMap<Continent, ContinentDto>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Value));
        }
    }
}
