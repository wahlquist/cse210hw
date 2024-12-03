class Program
{

    public static void SetPersonFirstName(Person person, string firstname)
    {
        person.SetFirstName(firstname);
    }
    public static void Main(string[] args)
    {
        
        Person bob = new Person("Bob", "Billy",37);
        Console.WriteLine(bob.GetPersonInfo());

        Police policeBob = new Police ("bob","Budge", 65, "taser");
        Console.WriteLine(policeBob.GetPoliceInformation());
        Console.WriteLine(policeBob.GetPersonInfo());


        SetPersonFirstName(policeBob, "doug the second");
        Console.WriteLine(policeBob.GetPoliceInformation());
        Console.WriteLine(policeBob.GetPersonInfo());


        List<Person> people = new List<Person>();
        people.Add(bob);
        people.Add(policeBob);
        

        foreach(Person person in people)
        {
            Console.WriteLine(person.GetPersonInfo());
        }

    }
}