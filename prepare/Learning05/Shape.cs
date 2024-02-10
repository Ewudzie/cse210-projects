using System;
using System.Reflection.Metadata.Ecma335;

public class Shape
{
    private string _color;

        public string GetColor()
        {
            return "";
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        public virtual double GetArea()
        {
            return 1;
        }
}