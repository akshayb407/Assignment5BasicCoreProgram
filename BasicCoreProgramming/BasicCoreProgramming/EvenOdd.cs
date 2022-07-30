using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class EvenOdd
    {
        public void EvenOrOdd()
        {
            Console.WriteLine("Even Or Odd Program");
            Console.WriteLine("Please Enter a Number to get Even Or Odd");
            int a = Int32.Parse(Console.ReadLine());
            
            if (a % 2 == 0)
            {
                Console.WriteLine(a + " is even number");
            }
            else
            {
                Console.WriteLine(a + " is odd number");
            }
        }

    }
}
