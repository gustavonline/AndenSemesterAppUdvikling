using System;
namespace KondiTal
{
	public class AgeSchema
	{
		public static void WriteAge()
        {

            Console.WriteLine("Now enter your age and press enter!");
            int age = int.Parse(Console.ReadLine());

            string vurdering = "";
            if (5 <= age && age <= 14 && Konditalfunktion.sexvalue == 0)
            {
                if (Konditalfunktion.result < 38)
                {
                    vurdering = "Very Low";
                }
                else if (39 <= Konditalfunktion.result && Konditalfunktion.result <= 43)
                {
                    vurdering = "Low";
                }
                else if (44 <= Konditalfunktion.result && Konditalfunktion.result <= 51)
                {
                    vurdering = "Average";
                }
                else if (52 <= Konditalfunktion.result && Konditalfunktion.result <= 56)
                {
                    vurdering = "High";
                }
                else if (57 <= Konditalfunktion.result && Konditalfunktion.result <= 59)
                {
                    vurdering = "Very High";
                }
                else if (60 <= Konditalfunktion.result && Konditalfunktion.result <= 90)
                {
                    vurdering = "Top";
                }
                else
                {
                    Console.WriteLine("Invalid data!");
                }
            }
            Console.WriteLine("Healthscore assessment = " + vurdering);
        }
    }
}

