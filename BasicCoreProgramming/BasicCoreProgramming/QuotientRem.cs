using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
   public class QuotientRem
    {
        public void QuotRem()
        {
            Console.WriteLine("Quotient And Reminder Program");
            Console.WriteLine("Please enter divisor and dividend");
            Console.WriteLine("Enter the Dividend");
            int dividend = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Divisor");
            int divisor = Int32.Parse(Console.ReadLine());
            
           

            int quotient = dividend / divisor;
            Console.WriteLine("The Quotient is:"+quotient);

            int remainder =  dividend % divisor;
            Console.WriteLine("The Remainder is:" + remainder);
        }
    }
}
