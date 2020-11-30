using AutoMapper;

namespace Api.Common.Mappings
{
    public interface ICommandMap<TDestination>
    {
        void Map(Profile profile) => profile.CreateMap(GetType(), typeof(TDestination));
    }
}
