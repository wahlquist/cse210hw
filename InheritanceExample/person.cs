 class Person 

{
private string _firstname;
private string _lastname;

private int _age;

public Person (string firstname, string lastname, int age)
{
    _firstname = firstname;
    _lastname=lastname;
    _age = age;

}





public string GetPersonStats()

{
    return $"{_firstname},{_lastname}, {_age}";
}

public void SetFirstName(string firstname)
{
    _firstname = firstname;
}
}