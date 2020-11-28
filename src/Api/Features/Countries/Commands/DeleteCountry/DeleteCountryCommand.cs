using Api.Common.Commands;

namespace Api.Features.Countries.Commands.DeleteCountry
{
    public class DeleteCountryCommand : DeleteCommand
    {
        public DeleteCountryCommand(int id)
            : base(id)
        {
        }
    }
}
