using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment assignment = new Assignment("Edwin Ewudzie", "Mathematics");
        //assignment.GetSummary();

        Console.WriteLine(assignment.GetSummary());
    }
}