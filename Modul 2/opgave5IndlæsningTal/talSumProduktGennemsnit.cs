using System;
namespace opgave5IndlæsningTal
{
	public class talSumProduktGennemsnit
	{

        public static void writeTal()
		{
            int sum = 0;
            int produkt = 1;
            int antal = 0;

            int tal = Convert.ToInt32(Console.ReadLine());

            while (tal != 3)
            {
                sum += tal;
                produkt *= tal;
                antal++;

                tal = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine(sum);
            Console.WriteLine(produkt);
            Console.WriteLine(antal);

        }
    }
}

