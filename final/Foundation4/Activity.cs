using System;
using System.Security.Cryptography.X509Certificates;
public class Activity
{
    public string _date;
    public int _lenght;

        public Activity (string date, int lenght)
        {
                _date = date;
                _lenght = lenght;
        }
        public string GetDate()
        {
            return _date;
        }
        public int GetLenght()
        {
            return _lenght;
        }
        public void SetDate(string date)
        {
            _date = date;
        }
        public void SetLenght(int lenght)
        {
            _lenght = lenght;
        }
        public virtual double GetDistance()
        {
            return 1;
        }
        public virtual double GetPace()
        {
            return 1;
        }
        public virtual double GetSpeed()
        {
            return 1;
        }
        public double GetSummary()
        {
            //string date;
            double distance = 1;
            double speed = 1;
            double pace = 1;

            return $"{distance}, {speed}, and {pace}";
        }


}