using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Extensions
{
    public static class MappingExtensions
    {
        public static async Task<List<TDestination>> ProjectToListAsync<TDestination>(
            this IQueryable source,
            IConfigurationProvider configuration,
            CancellationToken cancellationToken = default)
        {
            return await source.ProjectTo<TDestination>(configuration).ToListAsync(cancellationToken);
        }
    }
}
