using MediatR;

namespace Api.Features.Stadiums.Commands.NewStadium
{
    public class NewStadiumCommand : IRequest<int>
    {
        public string Name { get; set; }

        public int Capacity { get; set; }

        public int YearBuilt { get; set; }
    }
}
