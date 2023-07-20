using System;
namespace Opgave_5._1
{
	public class isUniqueList
	{
		public static void run()
		{
			var a = new List<int>(new int[] { 1, 2, 3, 4, 6 });
			Console.WriteLine(isUnique(a));

			a = new List<int>(new int[] { 1, 2, 3, 4, 6, 2, 4 });
			Console.WriteLine(isUnique(a));
		}


		private static bool isUnique(List<int> aList)
		{
			if (aList.Distinct().Count() == aList.Count())
				return true;
			else return false;
		
		}
	}
}

