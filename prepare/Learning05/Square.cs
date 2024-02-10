using System;
using System.Reflection.Metadata.Ecma335;

public class Square : Shape
{
    private double _side;
    public Square (string color, double side) : base(color)
    {
        _color = color;
        _side  = side;

    }

        public double GetSide()
        {
            double totalside;
            double side = 1;
            totalside = side * 2;


            return totalside;
        }

        public void SetSide(double side)
        {
            _side = side;

        }

        public override double GetArea()
        {
            return _side * 2;
        } 

}