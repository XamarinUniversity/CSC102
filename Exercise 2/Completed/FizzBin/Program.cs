using System;

namespace FizzBin
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//
			// Loop 100 times, from 1 to 100 inclusive.
			//
			for (int i = 1; i <= 100; i++)
			{
				if (i % 3 == 0 && i % 5 == 0) // test if i is divisible by both 3 and 5
				{
					Console.WriteLine("FizzBin!");
				}
				else if (i % 3 == 0) // test if i is divisible by 3
				{
					Console.WriteLine("Fizz");
				}
				else if (i % 5 == 0) // test if i is divisible by 5
				{
					Console.WriteLine("Bin");
				}
				else
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}