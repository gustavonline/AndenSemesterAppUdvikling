using System;
namespace Opgave_5._2
{
	class diceApp
	{
		public static void Run()
		{
			diceCup dc = new diceCup(2);

			for (int i = 0; i < 20; i++)
			{
				dc.shake();
				int[] result = dc.eyes();
				string meyer = dc.isMeyer();
				Console.WriteLine("dice 1: " + result[0] + " " + meyer);
				Console.WriteLine("dice 2: " + result[1] + " " + meyer);
                Console.WriteLine("_");
            }
		}
	}
}

