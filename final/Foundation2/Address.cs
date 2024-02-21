using System;
public class Address
{
    public string _street;
    public string _city;
    public string _state;
    public string _country;

        public Address(string street, string city, string state, string country)
        {
            _street = street;
            _city = city;
            _state  = state;
            _country = country;

        }
         public string DisplayAddress()
         {
            string address = $"Street Name: {_street}, \n City: {_city} \n State/Province: {_state} \n Country: {_country}";
            return address;
         }
}