using System;
using System.Net.Sockets;

public class Customer : Address
{
    public string _name;
    public Address _address;

        public Customer(string name, Address address, string street, string city, string state, string country):base(street, city, state, country)
        {
            _name  = name;
            _address = address;

        }

        public string GetName()
        {
            return _name;
        }
        public Address GetAddress()
        {
            return _address;
        }
        public void SetName(string name)
        {
            _name = name;
        }
         

}