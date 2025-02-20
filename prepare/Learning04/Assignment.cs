// Base class for all assignments
public class Assignment
{
    private string _studentName;
    private string _topic;


// Constructor to initialize student name and topic
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    public string GetStudentName()
    {
        return _studentName;
    }
}
