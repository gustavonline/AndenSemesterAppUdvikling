using System;
namespace opgave6PotensKvadratrod
{
	public class kvadratrodderPotens
	{
		public static bool isPowerOf2(int number)
		{
			int squareRoot = (int)Math.Sqrt(number);

            if (squareRoot * squareRoot == number)
			{
                return true;
            }
			return false;
        }
    }
}

