using Api.Common.Queries;
using Api.Extensions;
using Api.Features.Countries.Queries;
using AutoMapper;
using ApplicationCore.Common;
using ApplicationCore.Enumerations;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Continents.ListContinents
{
    public class ListContinentsQueryHandler : IQueryHandler<ListContinentsQuery, IEnumerable<ContinentDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ListContinentsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<ContinentDto>> Handle(ListContinentsQuery request, CancellationToken cancellationToken)
        {
            return Enumeration.GetAll<Continent>()
                .Select(c => _mapper.Map<Continent, ContinentDto>(c, opts =>
                    opts.AfterMap(async (src, dest) =>
                    {
                        dest.Countries = await _context.Countries.Where(x => x.ContinentId == c.Value)
                        .ProjectToListAsync<CountryDto>(_mapper.ConfigurationProvider);
                    })));
        }
    }
}
