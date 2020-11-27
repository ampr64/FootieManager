using Api.Common.Commands;

namespace Api.Features.Stadiums.Commands.UpdateStadium
{
    public class UpdateStadiumCommand : EntityCommand
    {
        public string Name { get; set; }

        public int Capacity { get; set; }

        public int YearBuilt { get; set; }
    }
}
