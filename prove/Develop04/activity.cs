// _welcome; activity


// GetActivity(): string

class Activity
{
private int _delay;



public void GetSpinner(int delay)
{
    _delay = delay;
    DateTime startTime = DateTime.Now;
DateTime endTime = startTime.AddSeconds(_delay);

while (DateTime.Now < endTime)
{
Console.Write("\b \b"); // Erase the + character
Console.Write("/");

Thread.Sleep(500);

Console.Write("\b \b"); // Erase the + character
Console.Write("-"); // Replace it with the - character

Thread.Sleep(500);

Console.Write("\b \b"); // Erase the + character
Console.Write("\\"); // Replace it with the - character
Thread.Sleep(500);

Console.Write("\b \b"); // Erase the + character
Console.Write("|"); // Replace it with the - character
Thread.Sleep(500);

//  Console.Write("\b \b"); // Erase the + character
//  Console.Write(""); // Replace it with the - character

}
}





}