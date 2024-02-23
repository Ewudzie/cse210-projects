using System;
using System.Data;
public class Running:Activity
{
    public double _distance;

        public Running (string date, int lenght, double distance):base(date, lenght)
        {
            _distance = distance;
        }

        public override int GetDistance()

        {
            double
            return _distance;
        }
}