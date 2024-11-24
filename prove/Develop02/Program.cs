using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Runtime.CompilerServices;

class Program
{
    public List<Menu> _jobs = new List<Menu>();
    
    static void Main(string[] args)
    {
         
        Journal MyJournal = new Journal();
        MyJournal._entries = new List<Write>();

        // int select = 0;
        // while (select != 5)
       {
        
        // Console.WriteLine("what would you like to do");
        // select = int.Parse(Console.ReadLine());
        // if (select = 1)
        } 

        int  menuselect = 0;
       while (menuselect != 5)
       {
   
    Console.WriteLine("1.  Write");
    Console.WriteLine("2.  Display");
    Console.WriteLine("3.  Load");
    Console.WriteLine("4.  Save");
    Console.WriteLine("5.  Quit");
    Console.WriteLine("");
    Console.WriteLine("what would you like to do");
    if (int.TryParse(Console.ReadLine(), out menuselect))
    {
    if (menuselect == 1)
    {{
        // Create a list of strings
        List<string> strings = new List<string> { "how did you see the hand of the lord", "how did you serve someone today", "what gospel lesson can you pull from today's events", "what was a significate interaction you made with another person", "what funny thing did you see today" };

        // Create a Random instance
        Random random = new Random();

        // Get a random index
        int randomIndex = random.Next(strings.Count); // Generates a number between 0 and strings.Count - 1

        // Get the string at the random index
        string randomString = strings[randomIndex];

        // Output the random string
        
         

       Write job1 = new Write();
       Console.WriteLine($"Random string: {randomString}");
       string kyle = Console.ReadLine();
         job1._write = kyle;
        job1._prompt =randomString;
        Console.WriteLine("date");
       string charles = Console.ReadLine();
        job1._date = charles;
        MyJournal.AddEntry(job1);

        // Write job2 = new Write();
        // job2._write = "Software Engineer";
        // job2._prompt = "Microsoft";
        // job2._date = kyle;
  

         Dock boat = new Dock();
         boat._name = "Allison Rose";
        //  boat.Display();
         boat._entries.Add(job1);
        //  boat._entries.Add(job2);
        }}
    else if (menuselect== 2)
    {

      foreach ( Write entry in MyJournal._entries)  {
        entry.Display();
      }}
    else if (menuselect==3)
    {


    }
    }
        }
       }
    }  


    // public void WriteToFile(string filename)
    // {
    //     using (StreamWrighter outputFile)
    // }
