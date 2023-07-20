using System;
namespace Opgave_3._1
{
	public class calculateAverage
	{
		public static double Average(int[]a)
		{
			double sum = a.Sum();
			return sum / a.Length;

        }
	}
}

