using System;

public class Rectangle : Shape
{
    private double _lenght;
    private double _width;

    public Rectangle(string color, double lenght, double width) : base(color)
    {
        _lenght = lenght;
        _width = width;
    }

        public double GetLenght()
        {
            double lenght = 1;
            return lenght;
        }

        public double GetWidth()
        {
            double width = 1;
            return width;
        }
        public void SetLenght(double lenght)
        {
            _lenght = lenght;
        }

        public void SetWidth(double width)
        {
            _width = width;
        }

        public override double GetArea()
        {
            return _lenght * _width;
        }


}