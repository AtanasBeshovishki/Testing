using System;
using System.Globalization;

namespace TwoDates
{
    class TwoDates
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(),
           "d.M.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);
            var holidaysCount = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1.0))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday ||
                    date.DayOfWeek == DayOfWeek.Sunday)
                    holidaysCount++;
            }
                
            Console.WriteLine(holidaysCount);
        }
    }
}
