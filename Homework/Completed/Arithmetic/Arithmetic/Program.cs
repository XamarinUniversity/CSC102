using System;

namespace Arithmetic
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string temp;

			//
			// User input
			//
			Console.Write("Please enter the first number: ");
			temp = Console.ReadLine();
			int x = int.Parse(temp);

			Console.Write("Please enter the second number: ");
			temp = Console.ReadLine();
			int y = int.Parse(temp);

			//
			// Addition
			//
			int sum = x + y;
			Console.WriteLine("{0} + {1} = {2}", x, y, sum);

			//
			// Subtraction
			//
			int difference = x - y;
			Console.WriteLine("{0} - {1} = {2}", x, y, difference);

			//
			// Multiplication
			//
			int product = x * y;
			Console.WriteLine("{0} * {1} = {2}", x, y, product);

			//
			// Division
			//
			if (y == 0)
			{
				Console.WriteLine("Error: denominator is zero");
			}
			else
			{
				int quotient = x / y;
				Console.WriteLine("{0} / {1} = {2}", x, y, quotient);
			}
		}
	}
}
