using System;
using System.ComponentModel.DataAnnotations;


class Listing
{
 

public int _length;


public void GetListing(int length)
{

    _length = length;

    Activity activity = new Activity();
    Console.Clear();
    Console.WriteLine("Get ready");
    activity.GetSpinner(3);
    Console.Clear();
    Console.WriteLine("Consider the folllowing prompt and write");
    Activity Activity = new Activity();
        string prompt=        Activity.GetListingPrompt();
        Console.WriteLine(Activity.GetListingPrompt());
    Console.WriteLine("");
    Console.Write("starting in...5");
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
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(length);
    int crepes = 0;
    while (DateTime.Now < endTime)
    {

  
  Console.Write("");
  Console.ReadLine();
  crepes = crepes+1;
  
    }
    Console.WriteLine($"your total was {crepes}");
    Thread.Sleep(4000);
    Console.Clear();
    Console.WriteLine("well done");
    Activity.GetSpinner(3);
    Console.Clear();
}}
