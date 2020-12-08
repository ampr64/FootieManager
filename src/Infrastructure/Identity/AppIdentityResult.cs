using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Identity
{
    public class AppIdentityResult
    {
        internal AppIdentityResult(bool succeeded, IEnumerable<string> errors)
        {
            Succeeded = succeeded;
            Errors = errors.ToArray();
        }

        public bool Succeeded { get; }

        public string[] Errors { get; }

        public static AppIdentityResult Success() => new AppIdentityResult(true, new string[] { });

        public static AppIdentityResult Failure(IEnumerable<string> errors) => new AppIdentityResult(false, errors);
    }
}
