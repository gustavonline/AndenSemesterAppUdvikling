using System;
namespace Opgave_4._1
{
	public class diceCreateDiceFrequency
	{
		public static void run()
		{
			int N = 1000000;
			int[] data = new int[N];

			dice d = new dice(6);

			for (int i = 0; i < N; i++)
			{
				d.Roll();
				data[i] = d.Eyes;
			}

			for (int eyes = 1; eyes <= 6; eyes++)
			{
				int frequence = Count(data, eyes);
				Console.WriteLine("Eyes: " + eyes + ", Frequence: " + frequence);
			}
		}

		static int Count(int[] data, int key)
		{
			int result = 0;
			foreach (int value in data)
			{
				if (value == key)
					result++;
			}
			return result;
		}
	}
}

