using Api.Common.Commands;
using AutoMapper;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Api.Features.Coaches.Commands.NewCoach
{
    public class NewCoachCommandHandler : NewCommandHandlerBase<NewCoachCommand, Coach>
    {

        public NewCoachCommandHandler(IApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
