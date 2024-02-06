using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity ()
    {
        
    }

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

        public void DisplayStartingMessage(string name, string description, int duration)
        {
            //string fullDisplay = name + " " + description + " " + duration.ToString();
        }

        public void DisplayEndMessage()
        {
            
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
        

        public void SetName(string name)
        {
            _name = name;
        }
        public void SetDescription(string description)
        {
            _description = description;
        }


}