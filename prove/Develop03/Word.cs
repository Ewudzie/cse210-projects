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
           _isHidden = true;

        }
        public void Show()
        {
            string text = _text;


        }
        public bool IsHidden()
        {
            return  _isHidden;

        }
        public string GetDisplayText()
        {
            return "";
        }

   
}