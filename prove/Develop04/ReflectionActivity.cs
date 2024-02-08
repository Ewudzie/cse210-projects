using System;

public class ReflectionActivity:Activity

{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    //Constructor
    public ReflectionActivity()
    {

    }
    public ReflectionActivity(List<string> prompt, List<string>questions, string name, string description, int duration):base(name, description, duration )
    { 
       _prompts = prompt;
       _questions = questions;


    }

        //creating methods
        public void Run()
        {

        }
        public string GetRandomPrompt()
        {
            return "";
        }
        public string GetRandomQuestion()
        {
            return "";
        }

        public void DisplayPrompt(string prompt)
        {
           // _prompts = prompt;
           

        }
        public void DisplayQuestions(string questions)
        {

        }
}
