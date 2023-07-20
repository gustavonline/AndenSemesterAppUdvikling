using System;
namespace Opgave_3._1
{
	public class readInputInt
	{
		public static int readInt(string preText)
		{
			Console.Write(preText);
			return int.Parse(Console.ReadLine());
		}
	}
}

