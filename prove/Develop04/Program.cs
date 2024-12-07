using System.Diagnostics;
using System.Runtime.InteropServices;

class Program
{
    public static void Main(string[] args)
    {



        Console.Clear();

int decision =0;

  while (decision!=4)
    {
        Console.WriteLine("Pick an activity");
        Console.WriteLine("");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");
        Console.WriteLine("4. quit");
        Console.WriteLine("Choose an option");
        int newnumber = int.Parse(Console.ReadLine());
        decision= newnumber;
        if (decision == 1)
        {
        
        Console.Clear();
        Console.WriteLine ("how long do you want the session: ");
         
        int number = int.Parse(Console.ReadLine());
        BreathingActivity Activity = new BreathingActivity();
                Activity.GetBreathing(number);
        // get spinner length
        }
        else if (decision ==2)
        {
            Console.Clear();
            Console.WriteLine ("how long do you want the session: ");
         
        int number = int.Parse(Console.ReadLine());
        Reflection Activity = new Reflection();
         Activity.GetReflection(number);
 


        }
 else if (decision ==3)
        {
            Console.Clear();
            Console.WriteLine ("how long do you want the session: ");
         
        int number = int.Parse(Console.ReadLine());
        Listing Activity = new Listing();
         Activity.GetListing(number);
 



        



    }













// }




    }
    }}








































// {
// DateTime startTime = DateTime.Now;
// DateTime endTime = startTime.AddSeconds(10);

// while (DateTime.Now < endTime)
// {
// Console.Write("\b \b"); // Erase the + character
// Console.Write("/");

// Thread.Sleep(500);

// Console.Write("\b \b"); // Erase the + character
// Console.Write("-"); // Replace it with the - character

// Thread.Sleep(500);

// Console.Write("\b \b"); // Erase the + character
// Console.Write("\\"); // Replace it with the - character
// Thread.Sleep(500);

// Console.Write("\b \b"); // Erase the + character
// Console.Write("|"); // Replace it with the - character
// Thread.Sleep(500);

// //  Console.Write("\b \b"); // Erase the + character
// //  Console.Write(""); // Replace it with the - character

// }