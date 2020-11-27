using Core.Entities;
using Core.Enumerations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Common
{
    public interface IApplicationDbContext
    {
        DbSet<Club> Clubs { get; set; }
        DbSet<Coach> Coaches { get; set; }
        DbSet<Continent> Continents { get; set; }
        DbSet<Country> Countries { get; set; }
        DbSet<League> Leagues { get; set; }
        DbSet<Player> Players { get; set; }
        DbSet<Stadium> Stadiums { get; set; }

        Task<int> CommitChangesAsync(CancellationToken cancellationToken = default);
        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
