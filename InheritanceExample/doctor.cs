class Police: Person
{
    private string _weapons;
    public Police ( string firstname,string lastname, int age, string tools): base(firstname,lastname,age)
    {
            _weapons = tools;
    }
    public string GetPoliceInformation()
    {
        return $"weapons:{_weapons}, {GetPersonInfo()}";
    }
    public override string GetPersonInfo()
    {
        return $" i am a police man, {base.GetPersonStats()}";
    }
}  