using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // For Part 1 and 2 where the user specified the number
        

       // Console.Write("What is the magic number? ");
       // string number = Console.ReadLine();

        //int magicNumber = int.Parse(number);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guessedNumber = -1;
        

       

        while (guessedNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            guessedNumber = int.Parse(Console.ReadLine());
            //int guessedNumber = int.Parse(guess);
           if (guessedNumber < magicNumber)
            {
            Console.WriteLine("Hiigher");
            }
            else if (guessedNumber > magicNumber)
            {
            Console.WriteLine("Lower");
            }
            else
            {
            Console.WriteLine("You guessed it!");
            }
        }
    }
}