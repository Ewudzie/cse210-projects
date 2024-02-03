using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment assignment = new Assignment("Edwin Ewudzie", "Mathematics");
        //assignment.GetSummary();

        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();


        MathAssignment mathHomework = new MathAssignment("Mary Arthur", "Fractions", "7.3", "8-19" );

        Console.WriteLine(mathHomework.GetSummary());

        Console.WriteLine(mathHomework.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment writeAssignment = new WritingAssignment("Jude Rose", "European History", "The Causes of World War II");

        Console.WriteLine(writeAssignment.GetSummary());
        Console.WriteLine(writeAssignment.GetWritingInformation());
    }
}