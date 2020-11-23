using MediatR;

namespace Api.Features.Stadiums.Commands
{
    public abstract class StadiumWriteCommandBase<TResponse> : IRequest<TResponse>
    {
        public string Name { get; set; }

        public int Capacity { get; set; }

        public int YearBuilt { get; set; }
    }
}
