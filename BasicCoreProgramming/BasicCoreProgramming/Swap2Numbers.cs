using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class Swap2Numbers
    {
        public void swap2Numbers()
        {


            Console.WriteLine("Swap 2 Numbers Program");
            Console.WriteLine("Please Enter Two Number a and b");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Number a before swapping is =" + a);
            Console.WriteLine("Number b before swapping is =" + b);
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Number a after swapping is =" + a);
            Console.WriteLine("Number b after swapping is =" + b);
        }
    }
}
