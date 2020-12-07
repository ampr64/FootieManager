using Core.Common;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IContextSeeder<TContext> where TContext : IApplicationDbContext
    {
        Task SeedAsync(TContext context);
    }

    public interface IMemoryContextSeeder<TContext> : IContextSeeder<TContext> where TContext : IApplicationDbContext
    {
    }

    public interface IDatabaseContextSeeder<TContext> : IContextSeeder<TContext> where TContext : IApplicationDbContext
    {
    }
}
