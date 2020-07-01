using System;

public class MainProgram
{
	int num1 = 0;
	int num2 = 2;
	public static void MainProgram()
	{
		// simple program that adds two inputted numbers 
		Console.WriteLine("this is a C# file");

		Console.WriteLine("type in a number");
		num1 = Console.ReadLine(Convert.ToInt32());

		Console.WriteLine("type in another number");
		num2 = Console.ReadLine(Convert.ToInt32());

		GetNumber(num1, num2);
	}

	public static int GetNumber(int a, int b)
    {
		int total = a + b;
		return total
    }
}
