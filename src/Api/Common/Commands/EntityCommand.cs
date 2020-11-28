namespace Api.Common.Commands
{
    public abstract class EntityCommand : ICommand
    {
        public int Id { get; set; }
    }
}
