public class WritingAssignment : Assignment
{
    private string _title;

    
    // Constructor to initialize student name, topic, and title
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}