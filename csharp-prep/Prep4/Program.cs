using System;

class Program
{
    static void Main(string[] args)
    {
    int input = 5;
    int numb = -100000000;
    List<int> words = new List<int>();
    while (input !=0)
    {
        Console.WriteLine("what would you like to add");
        input = int.Parse(Console.ReadLine());
        if(input != 0 ){
        words.Add(input);}
    }
    
    foreach (int word in words)
    {
        if (word >= numb)
        {
        numb = int.Parse(Console.ReadLine());
        Console.WriteLine(numb);
        }
    }
    int sum = words.Sum();
    Console.WriteLine($"the sum is: {sum}");
 

     int average = sum / words.Count;
     Console.WriteLine(average);
    }
}




// sum average larrgest quit on 0