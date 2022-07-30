using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class LargestAmong3Numbers
    {
        public void LargestOf3()
        {
            Console.WriteLine("Largest Amongs Three Numbers Program");

            Console.WriteLine("Enter the First Number");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Third number");
            int c = Int32.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine(a + " is largest among given 3 numbers");
            }
            else if (b > c && b > a)
            {
                Console.WriteLine(b + "is largest among given 3 numbers");
            }
            else
            {
                Console.WriteLine(c + " is largest among given 3 numbers");
            }
        }
    }
}
