using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        Lectures lectures = new Lectures();
        lectures.SetTitle("Lectures on C-Sharp");
        lectures.SetDescription("To teach about the principles of classes");
        lectures.SetDate("(9/02/2024)");
        lectures.SetTime("4pm GMT");
        //lectures.SetAddress(Address as);

        Console.WriteLine()
    }
}