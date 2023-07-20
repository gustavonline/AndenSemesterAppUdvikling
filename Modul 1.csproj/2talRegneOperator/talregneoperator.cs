using System;
namespace talRegneOperator
{
	public class talregneoperator
	{
		public static void WriteResult()
		{
            Console.WriteLine("Enter your first number and press enter!");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose your operator '+ - / *' and press enter!");

            string operator1 = Console.ReadLine();

            Console.WriteLine("Enter your second number and press enter!");

            int num2 = int.Parse(Console.ReadLine());

            int result = 0;
            if (operator1 == "+")
            {
                result = num1 + num2;
            }
            else if (operator1 == "-")
            {
                result = num1 - num2;
            }
            else if (operator1 == "*")
            {
                result = num1 * num2;
            }
            else if (operator1 == "/")
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Invalid operator!");
            }

            Console.WriteLine("Result = " + result);
        }
	}
}

