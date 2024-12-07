using System;

class Program1
{
    static void Main(string[] args)
    {  
        Hide hide = new Hide();
        int Kyle = 0;
        Scripture scripture = new Scripture();
        Console.Clear();
        Console.WriteLine("The glory of God is intelligence or in other words light and truth");
        string anwser2 = Console.ReadLine();


        while (Kyle != 8)
        {
            int charles=hide.GetHide();
            int maren = hide.GetHide();
       
        Console.Clear();
        Kyle = Kyle+1;
        
        scripture.Scripture2(charles,maren);
        
        
        string anwser = Console.ReadLine();
        }
        
        
        }
    }
