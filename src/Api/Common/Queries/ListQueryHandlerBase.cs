using Api.Common.Mappings;
using Api.Extensions;
using AutoMapper;
using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Common.Queries
{
    public class ListQueryHandlerBase<TQuery, TEntity, TDto> : IQueryHandler<TQuery, IEnumerable<TDto>>
        where TQuery : IQuery<IEnumerable<TDto>>
        where TEntity : Entity
        where TDto : IDto<TEntity>
    {
        protected readonly IApplicationDbContext _context;
        protected readonly IMapper _mapper;

        public ListQueryHandlerBase(IApplicationDbContext context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public virtual async Task<IEnumerable<TDto>> Handle(TQuery request, CancellationToken cancellationToken)
        {
            return await _context.Set<TEntity>()
                .ProjectToListAsync<TDto>(_mapper.ConfigurationProvider, cancellationToken);
        }

        protected async Task<IEnumerable<TDto>> HandleWithSorting<TKey>(TQuery request, CancellationToken cancellationToken, params (Expression<Func<TEntity, TKey>> KeySelector, SortDirection Direction)[] sortCriterias)
        {
            if (sortCriterias is null || !sortCriterias.Any())
                throw new ArgumentException("{parameterName} are required.", nameof(sortCriterias));

            return await _context.Set<TEntity>()
                .OrderByCriterias(sortCriterias)
                .ProjectToListAsync<TDto>(_mapper.ConfigurationProvider, cancellationToken);
        }
    }
}