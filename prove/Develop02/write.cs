public class Write
{
    public string _prompt;
    public string _write;
    public string _date;
    
 
    public void Display()
    {
        Console.WriteLine($"Date:{_date} Prompt({_prompt})|: {_write}");
    }
}
