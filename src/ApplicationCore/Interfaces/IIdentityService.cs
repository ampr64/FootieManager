using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IIdentityService<TResult>
    {
        Task<string> GetUserNameAsync(string userId);

        Task<(TResult Result, string UserId)> CreateUserAsync(string userName, string password);

        Task<TResult> DeleteUserAsync(string userId);
    }
}
