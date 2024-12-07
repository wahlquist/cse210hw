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
Console.Write("\b \b"); // Erase the + character

}
}


public string GetFirstReflectionPrompt()
{

    List<string> Prompts = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    Random random = new Random();


        int randomIndex = random.Next(Prompts.Count);


        string randomPrompt = Prompts[randomIndex];

        return randomPrompt;
}
public string GetSecondReflectionPrompt()
{

    List<string> Prompts = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    Random random = new Random();


        int randomIndex = random.Next(Prompts.Count);


        string randomPrompt = Prompts[randomIndex];
        Prompts.Remove(randomPrompt);

        return randomPrompt;
}

public string GetListingPrompt()
{
    List<string> Prompts = new List<string> { "Who are people that you appreciate?", "Whatcha think about rats?", "What are personal strengths of yours?", "Who are people that you have helped this week?","When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    Random random = new Random();


        int randomIndex = random.Next(Prompts.Count);


        string randomPrompt = Prompts[randomIndex];

        return randomPrompt;
}

}