using MediatR;

namespace Api.Features.Stadiums.Commands.UpdateStadium
{
    public class UpdateStadiumCommand : IRequest
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int YearBuilt { get; set; }
    }
}
