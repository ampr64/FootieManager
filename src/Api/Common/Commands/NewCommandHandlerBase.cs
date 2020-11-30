using Api.Common.Mappings;
using AutoMapper;
using Core.Common;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Common.Commands
{
    public abstract class NewCommandHandlerBase<TCommand, TEntity> : ICommandHandler<TCommand, int>
        where TCommand : ICommand<int>, ICommandMap<TEntity>
        where TEntity : Entity
    {
        protected readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public NewCommandHandlerBase(IApplicationDbContext context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public virtual async Task<int> Handle(TCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<TEntity>(request);

            await _context.Set<TEntity>().AddAsync(entity, cancellationToken);

            await _context.CommitChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
