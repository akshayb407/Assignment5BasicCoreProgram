using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class VowelConsonant
    {
		public 	void VowelOrConsonant(char x)
		{
			Console.WriteLine("Vowel Or Consonant Program");
			Console.WriteLine("Enter the Char to get Consonant Or Vowel");
		
			x = Console.ReadLine()[0];



			if (x == 'a' || x == 'e' || x == 'i' ||
							x == 'o' || x == 'u')
				Console.WriteLine("Enter Char is a Vowel");
			else
				Console.WriteLine("Enter Char is a Consonant");
		}
	}
}
