using AutoMapper;

namespace Api.Configuration.Mappings
{
    public interface IDto<T>
    {
        void Map(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
