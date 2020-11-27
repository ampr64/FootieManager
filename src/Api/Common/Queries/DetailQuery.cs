namespace Api.Common.Queries
{
    public abstract class DetailQuery<TResult> : IQuery<TResult>
    {
        public int Id { get; set; }
    }
}
