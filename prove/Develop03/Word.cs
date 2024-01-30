using System;

public class Word
{
    private string _text;
    private Boolean _isHidden;

    public Word(string text)
    {
        _text = text;

    }

        public void Hide ()
        {
           

        }
        public void Show()
        {
            string text = _text;


        }
        public bool IsHidden()
        {
             bool yes = _isHidden;

        }
        public string GetDisplayText()
        {
            return "";
        }

   
}