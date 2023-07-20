namespace opgave6PotensKvadratrod;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number that you want to be checked, if it isPowerOf2 or not!");
        int number = int.Parse(Console.ReadLine());

        bool result = kvadratrodderPotens.isPowerOf2(number);
        Console.WriteLine(result);
    }
}

