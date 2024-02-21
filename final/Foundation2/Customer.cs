using System;
using System.Net.Sockets;

public class Customer
{
    public string _name;
    public Address _address;

        public Customer(string name, Address address)
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