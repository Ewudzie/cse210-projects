using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        reference.SetBook("John");
        reference.SetChapter(3);
        reference.SeVerse(16);
        _words = text;

    }
        public void HideRandomWords(int numberToHide)
        {

        }
        public string GetDisplayText() 
        {
            return "";
        }
        public bool IsCompletelyHidden()
        {
           bool yes = true;
            return yes;
        }
        


}