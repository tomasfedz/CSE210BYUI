public class MathAssignment : Assignment
{
      // Store section and problems privately
    private string _section;
    private string _problems;


 // Constructor to initialize student name, topic, section, and problems
    public MathAssignment(string studentName, string topic, string section, string problems)
        : base(studentName, topic)
    {
        _section = section;
        _problems = problems;
    }


    // Get the homework list (e.g., "Section 7.3 Problems 8-19")
    public string GetHomeworkList()
    {
        return $"Section {_section} Problems {_problems}";
    }
}