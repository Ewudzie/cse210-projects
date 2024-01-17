using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);


    }

    static void DisplayWelcome()
    {
         Console.WriteLine("Welcome to the Program");
    }

    static string PromptUserName()
    {
            Console.Write($"Please enter your name: ");
            string name = Console.ReadLine();
            return name;
           

    }

    static int PromptUserNumber()
        {
            Console.Write($"Your faviorte number is: ");
            int number = int.Parse(Console.ReadLine());
            return number;
           
        }

    static int SquareNumber (int number)
        {
            int square = number * number;
            return square;
        }

    static void DisplayResult( string name, int square)
        {
            Console.WriteLine($"Your name is {name} and the square of your number is: {square}");
        }


    
}