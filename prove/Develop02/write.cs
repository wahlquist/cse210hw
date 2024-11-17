public class Write
{
    public string _prompt;
    public string _write;
    public string _date;
    
 
    public void Display()
    {
        Console.WriteLine($"{_date} ({_prompt}) {_write}-");
    }
}
