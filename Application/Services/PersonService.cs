using Core.Common;
using System;

namespace Application.Services
{
    public abstract class PersonService<TPerson> : ApplicationService<TPerson, int>, IPersonService<TPerson>
        where TPerson : Person
    {
        public PersonService(IUnitOfWork unitOfWork, IRepository<TPerson, int> repository)
            : base(unitOfWork, repository)
        {
        }

        public int CalculateAge(TPerson person)
        {
            int age = DateTime.Today.Year - person.BirthDate.Year;
            return person.BirthDate.Date > DateTime.UtcNow.Date
                ? age -= 1
                : age;
        }
    }
}
