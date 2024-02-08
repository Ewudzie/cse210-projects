using System;

public class ListingActivity:Activity
{  
    private int _count;
    private List<string> _prompt = new List<string>();



    //Methods

    public ListingActivity(int count, List<string> prompt, string name, string description, int duration): base(name, description, duration)
    {
        _count = count;
        _prompt = prompt;

    }
        public void Run()
        {

        }
        public string GetRandomPrompt()
        {
            return "";
        }
       /* public int GetCount()
        {


        }*/
        public void SetCount(int count)
        {
            _count = count;
        }

        public void SetRandomPrompt(string prompt)
        {
            //_prompt = prompt;
        }

        public List<string> GetListFromUser = new List<string>();
      
    
}