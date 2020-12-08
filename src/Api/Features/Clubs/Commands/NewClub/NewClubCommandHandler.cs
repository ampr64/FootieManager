using Api.Common.Commands;
using AutoMapper;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

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
