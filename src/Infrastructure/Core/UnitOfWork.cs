﻿using Core.Common;
using Infrastructure.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FootieManagerContext _footieManagerContext;

        public UnitOfWork(FootieManagerContext footieManagerContext)
        {
            _footieManagerContext = footieManagerContext;
        }

        public async Task<int> CommitChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _footieManagerContext.SaveChangesAsync(cancellationToken);
        }
    }
}