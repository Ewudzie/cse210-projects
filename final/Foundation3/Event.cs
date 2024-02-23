using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public abstract class Event
{
    public string _title;
    public string _description;
    public string _date;
    public string _time;
    public Address _address;

        public Event()
        {

        }

        public Event (string title, string description, string date, string time, Address address)
        {
            _title = title;
            _description = description;
            _date = date;
            _time = time;
            _address = address;

        }

        public string GetTitle()
        {
            return _title;
        }
        public string GetDescription()
        {
            return _description;
        }
        public string GetDate()
        {
            return _date;
        }
        public string GetTime()
        {
            return _time;
        }
        public Address GetAddress()
        {
            return _address;
        }
        public void SetAddress(Address address)
        {
            _address = address;
        }
        public void SetTitle(string title)
        {
            _title  = title;
        }
        public void SetDescription(string describtion)
        {
            _description  = describtion;
        }
        public void SetDate(string date)
        {
            _date = date;
        }
        public void SetTime(string time)
        {
            _time = time;
        }

        /*public string GetStandardDetials()
        {
            return $"Event Title: {_title} \n Description: {_description} \n Date: {_date} \n Time: {_time}";

        }*/

        /*public abstract string GetStandardDetails();

        public abstract string  GetFullDetails();
        public abstract string GetShortDescription();*/
        public abstract string GetDetails();
}