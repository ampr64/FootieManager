using Core.Common;
using Core.Services;
using Domain.Common;
using Domain.Data;
using System;

namespace Application.Services
{
    public class PersonService<TPerson> : ApplicationService<TPerson, int>, IPersonService<TPerson>
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
