using System;

class Program
{
    static void Main(string[] args)
    {
        // Base Assignment
        Assignment a1 = new Assignment(
            "Argy Milan",
            "Construction Estimating"
        );

        Console.WriteLine(a1.GetSummary());
        Console.WriteLine();

        // Math Assignment
        MathAssignment a2 = new MathAssignment(
            "Argy Milan",
            "Concrete Works",
            "5.2",
            "1-12"
        );

        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());
        Console.WriteLine();

        // Writing Assignment
        WritingAssignment a3 = new WritingAssignment(
            "Argy Milan",
            "Project Management",
            "Construction Site Safety Procedures"
        );

        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}