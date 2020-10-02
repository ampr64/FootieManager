namespace Core.Common
{
    public interface IPersonService<TPerson> : IService<TPerson, int>
        where TPerson : Person
    {
        public int CalculateAge(TPerson person);
    }
}
