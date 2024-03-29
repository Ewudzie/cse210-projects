using System;

public class Lectures:Event
{
    public string _speaker;
    public int _capacity;

        public Lectures()
        {
            
        }

        public Lectures (string title, string description, string date, string time, string speaker, int capacity, Address address):base(title, description, date, time, address)

        {
            _speaker = speaker;
            _capacity = capacity;
        }

        public string GetSpeaker()
        {
            return _speaker;
        }
        public int GetCapacity()
        {
            return _capacity;
        }

    /*public override string GetStandardDetails()
    {
        return $"Event Title: {_title} \n Description: {_description} \n Date: {_date} \n Time: {_time}";
    }*/

    public override string GetDetails()
    {
        return $"Event Title: {_title} \n Description: {_description} \n Date: {_date} \n Time: {_time} \n Address: {_address}\n Sepeaker: {_speaker} \n Capacity: {_capacity}";
    }
    /*public override string GetShortDescription()
    {
        return $"Event Title: {_title} \n Date: {_date} ";
    }*/

}