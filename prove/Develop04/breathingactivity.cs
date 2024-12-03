// _greeting:string
// _breathing:string

using System;
using System.ComponentModel.DataAnnotations;




class BreathingActivity
{

public int _length;


    public void GetBreathing(int length)
    {
        _length = length;
 DateTime startTime = DateTime.Now;
 DateTime endTime = startTime.AddSeconds(length);
 Activity activity = new Activity();
        Console.Clear();
        Console.WriteLine("Get ready");
        activity.GetSpinner(10);
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

// getBreathing():stirng
// Usespiner():?




// public void GetSpinner(int delay)
// {
//     _delay = delay;
//     DateTime startTime = DateTime.Now;
// DateTime endTime = startTime.AddSeconds(_delay);

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

