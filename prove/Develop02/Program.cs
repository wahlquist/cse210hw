using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Runtime.CompilerServices;

class Program
{
    public List<Menu> _jobs = new List<Menu>();
         
    static void Main(string[] args)
    {
  
        // Journal MyJournal = new Journal();
        // MyJournal._entries = new List<Write>();

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
    
        {
            Write write = new Write();
              List<string> _entry = new List<string>{};
            string _prompt = write.Prompt();
            string _write =Console.ReadLine();
            Console.WriteLine("what is the date today? ");
            string date= Console.ReadLine();
            write.storage(_write, date);
            _entry.Add(_write);
            _entry.Add(date);
            _entry.Add(_prompt);
            

            // _write,date, _prompt 
            
            // write.Display();
        }
    else if (menuselect== 2)
        {
            foreach (var word in _entry)
            {
                Console.Write(word);
            }
        }}
    else if (menuselect==3)
    {

    }
    else if (menuselect ==4)
    {

    }
        }
       }
    }  


  