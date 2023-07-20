using System;
namespace Opgave_3._1
{
	public class calculateVarians
	{
		public static double Varians(int[] a)
		{
			double sum = a.Sum();
            double avg = calculateAverage.Average(a);
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + Math.Pow(a[i] - avg, 2);

            }
            return sum / a.Length;
        }
	}
}

