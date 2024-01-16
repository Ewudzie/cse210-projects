using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("Please enter your exame score: ");

        string scoreInput = Console.ReadLine();
        
        int score = int.Parse(scoreInput);

        if(score >= 90)
        {
            Console.WriteLine("Your grade is: A ");
        }
        else if(score >=80)
        {
            Console.WriteLine("Your grade is: B ");
        }
        else if(score >=70)
        {
            Console.WriteLine("Your grade is: C ");
        }
        else if(score >=60)
        {
            Console.WriteLine("Your grade is: D ");
        }
        else
        {
            Console.WriteLine("Your grade is: F ");
        }

        if(score <=100 && score >= 70)
        {
            Console.WriteLine("Congratulations! You have passed.");
        }
        else
        {
            Console.WriteLine("Sorry you failed. Try to work hard next time.");
        }
    }
}