using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square square = new Square("Green", 3);
       // square.SetColor("Green");
       // square.SetSide(3);
        
        //Console.WriteLine($" {square.GetArea()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        shapes.Add(rectangle);

        Circle circle = new Circle("Red", 5);
        shapes.Add(circle);

        foreach(Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();
            Console.WriteLine($"Color {color} Shape is the area of {area}");
        }


    }
}