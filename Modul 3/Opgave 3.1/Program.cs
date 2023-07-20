namespace Opgave_3._1;
class Program
{
    static void Main(string[] args)
    {
        int amount = readInputInt.readInt("Indtast antallet af tal: ");
        int[] data = new int[amount];

        for (int i = 0; i < data.Length; i++) {
            data[i] = readInputInt.readInt("Indtast enkelte tal: ");
        }
        Console.WriteLine("Tallenes gennemsnit " + calculateAverage.Average(data));
        Console.WriteLine("Tallenes Varians " + calculateVarians.Varians(data));
        Console.WriteLine("Tallenes Afvigelse " + calculateAfvigelsen.Afvigelsen(data));
    }
}

