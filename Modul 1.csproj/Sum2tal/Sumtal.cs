using System;
namespace Sum2tal
{
	public class Sumtal
	{
		public static void WriteSum()
		{
            Console.WriteLine("Enter your first number and press enter!");

            int tal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number and press enter!");

            int tal2 = int.Parse(Console.ReadLine());

            int sum = tal1 + tal2;

            Console.WriteLine("sum = " + sum);
        }
	}
}

