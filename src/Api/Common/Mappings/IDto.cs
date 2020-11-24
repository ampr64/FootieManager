using AutoMapper;

namespace Api.Common.Mappings
{
    public interface IDto<T>
    {
        void Map(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
