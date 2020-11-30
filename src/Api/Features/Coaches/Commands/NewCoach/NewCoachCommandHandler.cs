using Api.Common.Commands;
using AutoMapper;
using Core.Common;
using Core.Entities;

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
