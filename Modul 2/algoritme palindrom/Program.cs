namespace algoritme_palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your word and press enter: ");

            string str1 = Console.ReadLine();

            char[] stringArray = str1.ToCharArray();
            Array.Reverse(stringArray);

            string str2 = new string(stringArray);
            Console.WriteLine(str1);
            Console.WriteLine(str2);

            bool result = booleanPalindrom.isPalindrom(str1, str2);
            Console.WriteLine(result);
        }
    }
}
