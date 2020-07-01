using System;

public class MainProgram
{
	
    static void Main(string[] args)
    {
        int num1 = 0;
        int num2 = 0;
        int total = 0;
        // simple program that adds two inputted numbers 
        Console.WriteLine("this is a C# file");

        Console.WriteLine("type in a number");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("type in another number");
        num2 = Convert.ToInt32(Console.ReadLine());

        total = num1 + num2;

        Console.WriteLine(total);

    }
}
