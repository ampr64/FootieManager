using Api.Common.Commands;

namespace Api.Features.Stadiums.Commands.NewStadium
{
    public class NewStadiumCommand : ICommand<int>
    {
        public string Name { get; set; }

        public int Capacity { get; set; }

        public int YearBuilt { get; set; }
    }
}
