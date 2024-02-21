using System;
public class Product
{
    public string _productName;
    public string _productId;
    public double _price;
    public int _quantity;

        public Product(string productName, string productId, double price, int quantity)
        {
            _productName = productName;
            _productId = productId;
            _price  = price;
            _quantity = quantity;

        }
        public string GetProductName()
        {
            return  _productName;
        }
        public string GetProductID()
        {
            return _productId;
        }
        public double GetPrice()
        {
            return _price;
        }
        public int GetQuantity()
        {
            return _quantity;
        }
        public void SetProductName(string productName)
        {
            _productName = productName;
        }
        public void SetProductId(string productId)
        {
            _productId = productId;
        }
        public void SetPrice(double price)
        {
            _price  = price;
        }
        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
        }

        public double GetTotalCost()
        {
            double totalCost = _price * _quantity;
            return totalCost;

        }


}