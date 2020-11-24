using Api.Exceptions;
using AutoMapper;
using Core.Common;
using Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Clubs.Queries.GetClubDetail
{
    public class GetClubDetailQueryHandler : IRequestHandler<GetClubDetailQuery, ClubDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetClubDetailQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ClubDto> Handle(GetClubDetailQuery request, CancellationToken cancellationToken)
        {
            var club = await _context.Clubs.FindAsync(request.Id, cancellationToken);

            if (club is null)
                throw new NotFoundException(nameof(Club), request.Id);

            return _mapper.Map<ClubDto>(club);
        }
    }
}
