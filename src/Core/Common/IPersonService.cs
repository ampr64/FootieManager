namespace Core.Common
{
    public interface IPersonService<TPerson> : IEntityService<TPerson, int>
        where TPerson : Person
    {
        public int CalculateAge(TPerson person);
    }
}
