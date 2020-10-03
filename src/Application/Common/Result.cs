using System.Linq;

namespace Application.Common
{
    public class Result
    {
        public string[] Errors { get; private set; } = new string[] { };

        public bool Success => Errors.Any();

        internal Result(params string[] errors) => Errors = errors;

        public static Result Successful() => new Result();

        public void AddError(string error)
        {
            Errors.Append(error);
        }
    }
}
