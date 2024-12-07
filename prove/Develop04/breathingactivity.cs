using System;
using System.ComponentModel.DataAnnotations;




class BreathingActivity
{
 public int _length;


    public void GetBreathing(int length)
    {
        _length = length;

 Activity activity = new Activity();
        Console.Clear();
        Console.WriteLine("Get ready");
        activity.GetSpinner(3);
        DateTime startTime = DateTime.Now;
 DateTime endTime = startTime.AddSeconds(length);
Console.Clear();
 while (DateTime.Now < endTime)
 {
 Console.WriteLine("");
 Console.Write("Breath in...5");
 Thread.Sleep(1000);
 Console.Write("\b \b"); // Erase the + character
 Console.Write("4");
 Thread.Sleep(1000);
Console.Write("\b \b"); // Erase the + character
 Console.Write("3");
 Thread.Sleep(1000);
 Console.Write("\b \b"); // Erase the + character
 Console.Write("2");
 Thread.Sleep(1000);
 Console.Write("\b \b"); // Erase the + character
 Console.Write("1");
 Thread.Sleep(1000);
  Console.Write("\b \b"); // Erase the + character
 Console.WriteLine("0");
 

 Console.Write("Breath out...5");
 Thread.Sleep(1000);
 Console.Write("\b \b"); // Erase the + character
 Console.Write("4");
 Thread.Sleep(1000);
 Console.Write("\b \b"); // Erase the + character
 Console.Write("3");
 Thread.Sleep(1000);
 Console.Write("\b \b"); // Erase the + character
 Console.Write("2");
 Thread.Sleep(1000);
 Console.Write("\b \b"); // Erase the + character
 Console.Write("1");
 Thread.Sleep(1000);
 Console.Write("\b \b"); // Erase the + character
 Console.WriteLine("0");
 Thread.Sleep(500);
 }
    Console.Clear();
    }
}

