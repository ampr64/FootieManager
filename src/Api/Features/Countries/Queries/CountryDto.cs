﻿using Api.Common.Mappings;
using Core.Entities;

namespace Api.Features.Countries.Queries
{
    public class CountryDto : IDto<Country>
    {
        public string Name { get; set; }

        public int ContinentId { get; set; }

        public string FlagImageUrl { get; set; }
    }
}
