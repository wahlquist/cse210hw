class Assignments


{

    private string _studentname;
    private string _topic;



    public Assignments(string studentname, string topic)
    {
        _studentname = studentname;
        _topic = topic;

    }
    public string GetSummary()
    {
        return $"{_studentname}: {_topic}";
    }
}