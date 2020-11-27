using Api.Common.Mappings;
using Api.Exceptions;
using AutoMapper;
using Core.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Common.Queries
{
    public abstract class GetEntityDetailQueryHandler<TQuery, TEntity, TDto> : IQueryHandler<TQuery, TDto>
        where TQuery : DetailQuery<TDto>
        where TEntity : Entity
        where TDto : IDto<TEntity>
    {
        protected readonly IApplicationDbContext _context;
        protected readonly IMapper _mapper;

        public GetEntityDetailQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<TDto> Handle(TQuery request, CancellationToken cancellationToken = default)
        {
            var entity = await _context.Set<TEntity>().FindAsync(new object[] { request.Id }, cancellationToken);

            if (entity is null)
                throw new NotFoundException(typeof(TEntity).Name, request);

            return _mapper.Map<TDto>(entity);
        }
    }
}
