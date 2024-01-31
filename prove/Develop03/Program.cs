using System;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");


        Reference referencescript = new Reference("John", 3, 16);
        string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        //string book = referencescript.SetBook(b);
        //int chapter = referencescript.SetChapter();
        
    
        Scripture scriptureRef = new Scripture(referencescript, text);
       
        Console.WriteLine($"{referencescript.GetDisplayText()}: {text}");

        
        
    }
}    