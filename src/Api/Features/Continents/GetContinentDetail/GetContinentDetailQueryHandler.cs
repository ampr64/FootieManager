using Api.Common.Queries;
using Api.Extensions;
using AutoMapper;
using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Continents.GetContinentDetail
{
    public class GetContinentDetailQueryHandler : IQueryHandler<GetContinentDetailQuery, ContinentDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetContinentDetailQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<ContinentDto> Handle(GetContinentDetailQuery request, CancellationToken cancellationToken)
        {
            return (await _context.Continents.Where(c => c.Value == request.Id)
                    .ProjectToListAsync<ContinentDto>(_mapper.ConfigurationProvider))
                    .FirstOrDefault();
        }
    }
}
