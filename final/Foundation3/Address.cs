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
         public string GetStreet()
         {
            return _street;
         }
         public string GetCity()
         {
            return _city;

         }
         public string GetState()
         {
            return _state;
         }
         public string GetCountry()
         {
            return _country;
         }
         public void SetStreet(string street )
         {
            _street  = street;
         }
         public void SetCity(string city)
         {
            _city = city;
         }
         public void SetState(string state)
         {
            _state  = state;
         }
         public void SetCountry(string country)
         {
            _country = country;

         }
         public string DisplayAddress()
         {
            string address = $"Street Name: {_street}, \n City: {_city} \n State/Province: {_state} \n Country: {_country}";
            return address;
         }
}