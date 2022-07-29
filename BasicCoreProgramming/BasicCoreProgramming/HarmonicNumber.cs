using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class HarmonicNumber
    {
        public void harmonicNumber()
        {
            Console.WriteLine("Enter the N Value to get Harmonic number");
            int N= Int32.Parse(Console.ReadLine());

            double result = 3;
            for (int i = 1; i <= N; i++) 
            {
                result = (result + 1) / i;
            }
            Console.WriteLine($"Harmonic number is ={result}");
        }

    }
}
