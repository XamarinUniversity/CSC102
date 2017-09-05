using System;

namespace Parsing
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//
			// Prompt the user to enter their age. This uses Console.Write instead of
			// Console.WriteLine so the cursor stays on the same line as the prompt.
			//
			Console.Write("Please enter your age: ");

			//
			// Read the age. The user's input arrives in the program as a string,
			// e.g. the input will be something like the sequence of characters "45".
			//
			string yourAge = Console.ReadLine();

			//
			// Convert the age from string to int.
			//
			int yourAgeAsInt = int.Parse(yourAge);

			//
			// Output the age.
			//
			Console.WriteLine("Your age is {0}", yourAge.ToString());
		}
	}
}