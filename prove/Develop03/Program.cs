using System;
using System.Collections.Concurrent;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");


        Reference referencescript = new Reference("John", 3, 16);
        string text1 = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        Reference referenceScripture2 = new Reference("Proverb", 3, 5, 6);
        //string text2 = "Trust in the Lord with all thine heart; and lean not unto thine cown understanding.In all thy ways acknowledge him, and he shall direct thy paths.";
        //string book = referencescript.SetBook(b);
        //int chapter = referencescript.SetChapter();
        
    
        Scripture scriptureRef = new Scripture(referencescript, text1);
       
        Console.WriteLine($"{referencescript.GetDisplayText()}: {text1}");
        Console.WriteLine();

        Console.WriteLine("Press Enter to continue or type 'quit' to finish: ");
        string userEnter =  Console.ReadLine();
        //string userQuit = "";

       /* while(userEnter != "quit")
        {
            int countHideWord = 0;
            int totalCount =+ countHideWord; 
            Console.WriteLine("___");
            Console.WriteLine($"{text1.Length}");
            Console.Clear();

        }*/


       if (userEnter == Console.ReadLine())
        {
            Console.Clear();
            Console.WriteLine("___");

        }
        else if(userEnter == "quit")
        {
            Console.Write("Thank you playing the scripture memory game.");
        }

        

        
        
    }
}    