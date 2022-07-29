using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class LeapYear
    {
         public void CheckLeapYear()
        {
            Console.WriteLine("Enter the year");
            long year = long.Parse(Console.ReadLine());

            
            if (year % 4 == 0)
            {
                Console.WriteLine(year + " is leap year");
            }
            else
            {
                Console.WriteLine(year + " is not leap year");
            }
        }
    }
}
