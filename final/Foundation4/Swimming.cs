using System;
public class Swimming:Activity
{
    public double _pace;

        public Swimming(string date, int lenght, double pace):base(date, lenght)
        {
            _pace = pace;
        }

        public override double GetPace()
        {
            double totalpace;
            totalpace = 60 / _pace;


            return totalpace;
        }

        public string GetSummary()
        {
            return 
        }


}