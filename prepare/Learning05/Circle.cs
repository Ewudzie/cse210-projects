using System;

public class Circle : Shape
{
    private double _radius;

        public double GetRadius()
        {
            return 1;
        }

        public void SetRadius(double radius)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return  Math.PI * ((_radius) ** 2);
        }
}