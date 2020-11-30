using Api.Common.Commands;
using AutoMapper;
using Core.Common;
using Core.Entities;

namespace Api.Features.Clubs.Commands.NewClub
{
    public class NewClubCommandHandler : NewCommandHandlerBase<NewClubCommand, Club>
    {
        public NewClubCommandHandler(IApplicationDbContext context, IMapper mapper) :
            base(context, mapper)
        {
        }
    }
}
