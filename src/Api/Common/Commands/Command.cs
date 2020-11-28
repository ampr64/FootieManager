namespace Api.Common.Commands
{
    public abstract class DeleteCommand : ICommand
    {
        public int Id { get; set; }

        public DeleteCommand(int id) => Id = id;
    }

    public abstract class UpdateCommand : ICommand
    {
        public int Id { get; set; }
    }
}
