using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        Address address = new Address("Lorins Ln", "Bellview", "Collorado", "USA");

        Lectures lectures = new Lectures("Lectures on C-Sharp", "To teach about the principles of classes", "(9/02/2024)", "4pm GMT", "Dr. Lawson", 150, address);
        /*lectures.SetTitle("Lectures on C-Sharp");
        lectures.SetDescription("To teach about the principles of classes");
        lectures.SetDate("(9/02/2024)");
        lectures.SetTime("4pm GMT");*/
        //lectures.SetAddress(Address as);

        List<Event> events = new List<Event>();
        events.Add(lectures);

        Receptions receptions = new Receptions("Anniversary", "Edwins 10th Wedding Annivesary","14/02/2024", "5PM GMT", address, "Yes will be there!");
        events.Add(receptions);

        OutdoorGatherings outdoorGatherings = new OutdoorGatherings("BIRTHDAY", "Kojo's 60th Birthday","14/10/2024", "5PM GMT", address, "Sunny");

        events.Add(outdoorGatherings);

        foreach(Event e in events)
        {
            string details = e.GetDetails();
            Console.WriteLine($"The event detials are: {details}");

        }



    }
}