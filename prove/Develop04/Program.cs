using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        Console.WriteLine("Menu Option: \n 1. Start Breathing Activity \n 2. Start Reflecting Activity \n 3. Start Listing Activity \n 4. Quit");
        Console.WriteLine();
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            BreathingActivity breathingActivity = new BreathingActivity();
            //"Welcome To The Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
            
            breathingActivity.SetName("Breathing Activity");
            breathingActivity.SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            
            Console.WriteLine();
            Console.Write("How long would you want to take this activity: ");
            
            string secondsInput = Console.ReadLine();
        
            int seconds = int.Parse(secondsInput);
            if(seconds != 0)
            {
                //intantiating a Breathing class


                 for (int i = 5; i > 0; i--)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(3000);
                    Console.WriteLine("\b \b");

                }

            }


            //second = (30);

            breathingActivity.SetDuration(30);
            //Console.ReadLine(breathingActivity.SetDuration());

        }
        else if(choice == "2")
        {
            ReflectionActivity reflectionActivity = new ReflectionActivity();
            reflectionActivity.SetName("Reflective Activity");
            reflectionActivity.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            
        }



        
        



        Console.WriteLine("Done");
    }
}