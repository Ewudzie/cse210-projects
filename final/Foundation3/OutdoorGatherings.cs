using System;

public class OutdoorGatherings:Event
{
    public string _weather;

        public OutdoorGatherings(string title, string description, string date, string time, string weather):base(title, description, date, time)
        {
            _weather = weather;

        }

        public string GetWeather()
        {
            return _weather;
        }
        public void SetWeather(string weather)
        {
            _weather = weather;
        }

    public override string GetDetails()
    {
         return $"Event Title: {_title} \n Description: {_description} \n Date: {_date} \n Time: {_time} \n Weather: {_weather}";
    }
}