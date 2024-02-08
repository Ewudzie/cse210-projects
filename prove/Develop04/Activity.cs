using System;

public class Activity
{
    protected string _name;
    protected string _description;
    private int _duration;

    public Activity ()
    {
        
    }
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

        public void DisplayStartingMessage(string name, string description, int duration)
        {
            _name = name;
            _description = description;
            _duration = duration;
        }

        public void DisplayEndMessage()
        {
            string endMessage = "Well Done!";
        }

        public void ShowSpinner(int numberOfSeconds)
        {
            
        }

        public void ShowCountDown(int second)
        {

        }

        public string GetName()
        {
            return $"{_name}";
        }

        public string GetDescription()
        {
            return $"{_description}";
        }

        public int GetDuration()
        {
            
           return _duration;
        }
        

        public void SetName(string name)
        {
            _name = name;
        }
        public void SetDescription(string description)
        {
            _description = description;
        }
        public void SetDuration(int duration)
        {
            _duration = duration;
        }


}