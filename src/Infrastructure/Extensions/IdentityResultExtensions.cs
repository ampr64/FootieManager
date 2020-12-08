using Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace Infrastructure.Extensions
{
    public static class IdentityResultExtensions
    {
        public static AppIdentityResult ToApplicationResult(this IdentityResult result) =>
            result.Succeeded ? AppIdentityResult.Success()
                             : AppIdentityResult.Failure(result.Errors.Select(e => e.Description));
    }
}
