using Api.Common.Commands;
using Api.Common.Mappings;
using ApplicationCore.Entities;

namespace Api.Features.Stadiums.Commands.NewStadium
{
    public class NewStadiumCommand : ICommand<int>, ICommandMap<Stadium>
    {
        public string Name { get; set; }

        public int Capacity { get; set; }

        public int YearBuilt { get; set; }
    }
}
