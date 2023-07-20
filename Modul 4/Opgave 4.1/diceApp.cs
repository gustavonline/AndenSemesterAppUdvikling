using System;
namespace Opgave_4._1
{
	public class diceApp
	{
		public static void Run()
		{
			for (int i = 0; i < 20; i++)
			{
				dice d = new dice(6);
				d.Roll();
				Console.WriteLine("eyes: " + d.Eyes);
			}
			Console.WriteLine("Antal terninger: " + dice.countDice);
		}
	}
}

