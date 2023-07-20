using System;

namespace algoritme;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tast ind prisen på porto:");
        int porto = Convert.ToInt32(Console.ReadLine());
        int diff = porto % 5;




        Console.WriteLine("Rest: " + diff);


        int i;
        var stamps = new List<int>();
        for (i = porto; i > 4; i -= 5)
        {​​​​​​​
                stamps.Add(5);
        }​​​​​​​
            if (diff == 1)
        {​​​​​​​
                stamps.RemoveAt(1);
            stamps.Add(3);
            stamps.Add(3);
        }​​​​​​​
            else if (diff == 2)
        {​​​​​​​
                stamps.RemoveAt(1);
            stamps.RemoveAt(1);
            stamps.Add(3);
            stamps.Add(3);
            stamps.Add(3);
            stamps.Add(3);
        }​​​​​​​
            else if (diff == 3)
        {​​​​​​​
                stamps.Add(3);
        }​​​​​​​
            else if (diff == 4)
        {​​​​​​​
                stamps.RemoveAt(1);
            stamps.Add(3);
            stamps.Add(3);
            stamps.Add(3);
        }​​​​​​​


            Console.WriteLine(string.Join(", ", stamps));
    }
}

