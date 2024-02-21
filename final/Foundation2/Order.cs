using System;


public class Order : Product
{
    List<Product>_product = new List<Product>();
    public Customer _customer;

       
       public Order(string productName, string productId, double price, int quantity) : base(productName, productId, price, quantity)
       {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;

       }
    

        public Order(Customer customer, List<Product> product, string productName, string productId, double price, int quantity) : base (productName, productId, price, quantity)
        {
            _product = product;
            _customer = customer;

        }

       /* public void PackingLable(string name , string productID)
        {

        }*/


        /*public void ShippingLable(string name, Customer customer)
        {
            _productName = name;
            _customer = customer;

        }*/

        public string GetShippingLable()
        {
            
            return $"Name: {_product} Customer: {_customer._name}";
        }

         public string GetPackingLable()
        {
            return $"Name {_product} ID {_productId}";
        }

        public double GetTotalShippingCost()
        {

            double USAShippingCost = 3;
            //double NonUSAShippingCost = 35;
            return USAShippingCost;


        }


}