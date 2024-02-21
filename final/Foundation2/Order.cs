using System;


public class Order
{
    List<Product>_product = new List<Product>();
    public Customer _customer;
    

        public Order()
        {

        }

        public void PackingLable(string name , string productID)
        {

        }
        public void ShippingLable(string name, string customer)
        {
            name = "";
            _customer = customer;

        }

        public double GetTotalShippingCost()
        {

        }


}