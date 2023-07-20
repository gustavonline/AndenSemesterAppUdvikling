using System;
namespace KondiTal
{
    public class Konditalfunktion
    {
        public static int distance;
        public static int sexvalue;
        public static int result;

        public static void WriteKondi()
        {
            Console.WriteLine("Enter your running distance and press enter!");
            int distance = int.Parse(Console.ReadLine());

            Console.WriteLine("Now enter your sex 'Male or Woman' and press enter!");
            string sex = Console.ReadLine();

            if (sex == "Male")
            {
                sexvalue = 1;
            }
            else if (sex == "Woman")
            {
                sexvalue = 0;
            }

            result = (int)(18.38 * (0.03301 * distance) - (5.92 * sexvalue));

            Console.WriteLine("Your healthscore is " + result);

        }
    }
}
