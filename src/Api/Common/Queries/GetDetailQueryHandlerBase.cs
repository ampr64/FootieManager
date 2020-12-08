using Api.Common.Mappings;
using Api.Exceptions;
using AutoMapper;
using ApplicationCore.Common;
using ApplicationCore.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Common.Queries
{
    public abstract class GetDetailQueryHandlerBase<TQuery, TEntity, TDto> : IQueryHandler<TQuery, TDto>
        where TQuery : DetailQuery<TDto>
        where TEntity : Entity
        where TDto : IDto<TEntity>
    {
        protected readonly IApplicationDbContext _context;
        protected readonly IMapper _mapper;

        public GetDetailQueryHandlerBase(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual async Task<TDto> Handle(TQuery request, CancellationToken cancellationToken = default)
        {
            var entity = await _context.Set<TEntity>().FindAsync(new object[] { request.Id }, cancellationToken);

            if (entity is null)
                throw new NotFoundException(typeof(TEntity).Name, request);

            return _mapper.Map<TDto>(entity);
        }
    }
}
