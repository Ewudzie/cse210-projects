using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Order order1 = new Order("Cheese", "001", 20, 2);
        order1.SetProductName("Cheese");
        order1.SetProductId("001");
        order1.SetPrice(20);
        order1.SetQuantity(2);

        Console.WriteLine(order1.GetTotalShippingCost());
        Console.WriteLine($" Total cost is: {order1.GetTotalCost}, shipping lable: {order1.GetShippingLable()}, and packing lable{order1.GetPackingLable()}");
        
        Order order2 = new Order("Orange", "002", 30, 3);
        order2.SetProductName("Orange");
        order2.SetProductId("002");
        order2.SetPrice(30);
        order2.SetQuantity(1);

        Console.WriteLine(order2.GetTotalShippingCost());
        Console.WriteLine($" Total cost is: {order2.GetTotalCost}, shipping lable: {order2.GetShippingLable()}, and packing lable{order2.GetPackingLable()}");


    }
}