using System;
using System.ComponentModel.DataAnnotations;




class Reflection
{
 

public int _length;


public void GetReflection(int length)
{

    _length = length;

    Activity activity = new Activity();
    Console.Clear();
    Console.WriteLine("Get ready");
    activity.GetSpinner(3);
    Console.Clear();
    Console.WriteLine("Consider the folllowing prompt");
    Activity Activity = new Activity();
        string prompt=        Activity.GetFirstReflectionPrompt();
        Console.WriteLine(Activity.GetFirstReflectionPrompt());
    string anwser = Console.ReadLine();
    Console.Clear();
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(length);
    while (DateTime.Now < endTime)
    {

  Console.Write(Activity.GetSecondReflectionPrompt());
  Activity.GetSpinner(4);
  Console.WriteLine("");

  
    }
    Console.Clear();
    Console.WriteLine("well done");
    Activity.GetSpinner(3);
    Console.Clear();
}}



