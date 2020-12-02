using Core.Services;
using System;

namespace Api.Common.Core
{
    public class AgeCalculator : IAgeCalculator
    {
        public int CalculateAge(DateTime dateFrom)
        {
            var age = DateTime.Today.Year - dateFrom.Year;
            return dateFrom.Date > DateTime.UtcNow.Date ? age-- : age;
        }
    }
}
