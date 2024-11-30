using System;

class Program
{
    static void Main(string[] args)
    {
        Assignments student = new Assignments("samantha", "Math");
        Console.WriteLine(student.GetSummary());


        // Police policeBob = new Police("bob", "Budge", 65, "taser");
        // Console.WriteLine(policeBob.GetPoliceInformation());
        // Console.WriteLine(policeBob.GetPersonInfo());
    }
}