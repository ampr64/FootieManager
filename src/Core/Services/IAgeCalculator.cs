using System;

namespace Core.Services
{
    public interface IAgeCalculator
    {
        int CalculateAge(DateTime dateFrom);
    }
}
