using System;

namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime dob)
        {
            var age = DateTime.Today.Year - dob.Year;
            
            if (dob.Date > DateTime.Today.AddYears(-age)) age--;

            return age;
        }
    }
}