using System;

class Program
{
    static void Main(string[] args)
    {
     Console.WriteLine(" what is your grade");
     string grade = Console.ReadLine();
     int x = int.Parse(grade);

        if (x >= 90)
        {
          Console.WriteLine("A ");  
        }
        else if (x >= 80)
        {
          Console.WriteLine("B");  
        }
         else if (x >= 70)
        {
          Console.WriteLine("c");  
        }
         else if (x >= 60)
        {
          Console.WriteLine("d");  
        }
        else
        {
          Console.WriteLine("F");  
        }

    }
}