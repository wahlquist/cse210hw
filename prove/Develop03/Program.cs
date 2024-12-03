using System;

class Program1
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Scripture scripture1 =  new Scripture();
            Console.WriteLine(scripture1.GetFullScripture());
            string next = Console.ReadLine();
            
            if (next == "quit")
            {
                break;
            }

          
        }
    }
}