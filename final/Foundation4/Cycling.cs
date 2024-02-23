using System;
public class Cycling : Activity
{
    public double _speed;

        public Cycling(string date, int lenght, double speed):base(date, lenght)
        {
            _speed = speed;

        }

        public override double GetSpeed()
        {
            return _speed;
        }
}