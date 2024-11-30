class Program
{
    public static void Main(string[] args)
    {
        
        Person bob = new Person("Bob", "Billy",37);
        Console.WriteLine(bob.GetPersonInfo());

        Police policeBob = new Police ("bob","Budge", 65, "taser");
        Console.WriteLine(policeBob.GetPoliceInformation());
        Console.WriteLine(policeBob.GetPersonInfo());
    }
}