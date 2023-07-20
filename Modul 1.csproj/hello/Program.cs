namespace hello;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name and press enter");
        string name = Console.ReadLine();

        //int tal = int.Parse(name);

        int hour = DateTime.Now.Hour;

        Greeting.WriteGreeting(name, hour);



    }
}

