using AutoMapper;

namespace Api.Common.Mappings
{
    public interface IDto<TSource>
    {
        void Map(Profile profile) => profile.CreateMap(typeof(TSource), GetType());
    }
}
