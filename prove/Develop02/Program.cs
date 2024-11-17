using System;

class Program
{
    public List<Menu> _jobs = new List<Menu>();
    static void Main(string[] args)
    {


        // int select = 0;
        // while (select != 5)
       {
        
        // Console.WriteLine("what would you like to do");
        // select = int.Parse(Console.ReadLine());
        // if (select = 1)

       } 
    

       Write job1 = new Write();
       Console.WriteLine("what do you want to write");
       string kyle = Console.ReadLine();
         job1._write = kyle;
        job1._prompt = "Microsoft";
        Console.WriteLine("date");
       string charles = Console.ReadLine();
        job1._date = charles;
        

        Write job2 = new Write();
        job2._write = "Software Engineer";
        job2._prompt = "Microsoft";
        job2._date = kyle;

         Dock boat = new Dock();
         boat._name = "Allison Rose";

         boat._entries.Add(job1);
         boat._entries.Add(job2);

         boat.Display();
    }
}

    // public void WriteToFile(string filename)
    // {
    //     using (StreamWrighter outputFile)
    // }
