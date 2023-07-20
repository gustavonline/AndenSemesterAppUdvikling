using System;
namespace Opgave_3._1
{
	public class calculateAfvigelsen
	{
		public static double Afvigelsen(int[] a)
		{

            return Math.Sqrt(calculateVarians.Varians(a));
        }
	}
}

