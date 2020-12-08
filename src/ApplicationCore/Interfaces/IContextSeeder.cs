using ApplicationCore.Common;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
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
