using System;
namespace Opgave_5._2
{
	public class diceCup
	{
		//Liste state
		private List<dice> myDices;

		//opretter objekt diceCup
		public diceCup(int quantityDices)
		{
			myDices = new List<dice>();
			for (int i = 0; i < quantityDices; i++)
			{
				myDices.Add(new dice(6));
			}
		}

		//method
		public void shake()
		{
			foreach (dice dice in myDices)
			dice.Roll();
			
		}

		public int[] eyes()
		{
			int[] result = new int[myDices.Count];
			for (int i = 0; i < myDices.Count; i++)
			{
				result[i] = myDices[i].Eyes;
			}
			return result;
		}

		public string isMeyer()
		{
			if (eyes()[0] == 1 && eyes()[1] == 2)
				return "MEYER! :D";
			return " ";
		}
	}
}

