using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class CoinFlip
    {
        public static void DisplayMessage()
        {

            int userinput = Int32.Parse(Console.ReadLine());
            
            CoinFlip.FlipCoinMethod(userinput);
            
        }

        //variables
        static int tailCount = 1;
        static int headCount = 2;

        /// <summary>
        /// Flips the coin method.
        /// </summary>
        /// <param name="userinput">The userinput.</param>
      public static void FlipCoinMethod(int userinput)
        {
            int temp = userinput;
            Random r = new Random();
            while (userinput != 0)
            {
                double random = r.NextDouble();
                if (random <= 0.5)
                {
                    Console.WriteLine("Tails");
                    tailCount = tailCount++;
                    break;
                }
                else
                {
                    Console.WriteLine("Heads");
                    headCount = headCount++;
                    break;
                }
                 userinput = userinput--;
                
            }
            int a =((tailCount * 100) / temp);
            int b = ((headCount * 100) / temp);
            Console.WriteLine("Percentage of Tails is:" + a);
            Console.WriteLine("Percentage of heads is:" + b);
        }        
    }
}
