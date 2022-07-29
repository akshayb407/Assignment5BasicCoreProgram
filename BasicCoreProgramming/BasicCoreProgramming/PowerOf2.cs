using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class PowerOf2
    {
        public void powerOf2()
        {
            {
                Console.WriteLine("Please enter N value to get Power Of 2");
                int N = Int32.Parse(Console.ReadLine());
                int temp = N;
                int result = 1;
                while(N!=0)
                {
                    result = result * 2;
                    N--;
                }
             Console.WriteLine($"Power Of 2^ {temp} is: {result}");
            }
        }
    }
}
