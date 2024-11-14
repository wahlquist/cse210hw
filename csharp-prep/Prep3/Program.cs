using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int numb = randomGenerator.Next(1,11);

    int kyle = 0;

    while (kyle != numb)
    {

       Console.WriteLine("what number ");
        kyle = int.Parse(Console.ReadLine());
        if (kyle < numb)
        {
            Console.WriteLine("higher");
        }
         else if  ( kyle > numb)
        {
            Console.WriteLine("lower");
        }
    }
    Console.WriteLine("well done");
}
}