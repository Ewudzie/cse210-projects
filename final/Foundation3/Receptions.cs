using System;
public class Receptions : Event
{
    public string _rsvp;

        public Receptions()
        {
            
        }
        public Receptions(string title, string description, string date, string time, Address address, string rsvp):base(title, description, date, time, address)
        {
            _rsvp = rsvp;

        }

        public string GetRSVP()
        {
            return _rsvp;
        }
        public void SetRSVP(string rsvp)
        {
            _rsvp = rsvp;
        }

        public override string GetDetails()
    {
        return $"Event Title: {_title} \n Description: {_description} \n Date: {_date} \n Time: {_time} \n Address: {_address} \n RSVP: {_rsvp}";
    }
   
}