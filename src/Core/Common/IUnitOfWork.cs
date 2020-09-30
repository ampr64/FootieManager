using System.Threading;
using System.Threading.Tasks;

namespace Core.Common
{
    public interface IUnitOfWork
    {
        Task<int> CommitChangesAsync(CancellationToken cancellationToken = default);
    }
}
