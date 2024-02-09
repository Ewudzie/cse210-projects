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
            
            breathingActivity.SetName("Welcome to the Breathing Activity!");
            breathingActivity.SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            //breathingActivity.DisplayEndMessage("");
            
            Console.WriteLine();
            Console.WriteLine(breathingActivity.GetName());
            Console.WriteLine();
            Console.WriteLine(breathingActivity.GetDescription());

            Console.Write("How long would you want to take this activity: ");
            Console.WriteLine();
            string secondsInput = Console.ReadLine();
        
            int seconds = int.Parse(secondsInput);
            if(seconds != 0)
            {
                
                //intantiating a Breathing class


                /* for (int i = 5; i > 0; i--)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                    //Console.Write("\b \b");

                }*/
                //spining
                // |/-\|/-\
                Console.Write("Breath in");
                List<string> animationstring = new List<string>();
                animationstring.Add("|");
                animationstring.Add("/");
                animationstring.Add("-");
                animationstring.Add("\\");
                animationstring.Add("|");
                animationstring.Add("/");
                animationstring.Add("-");
                animationstring.Add("\\");
                foreach (string s in animationstring)
                {
                    
                    Console.WriteLine();
                    Console.WriteLine("Out");
                    Console.Write(s);
                
                    Thread.Sleep(2000);

                    Console.Write("\b \b");

                }
                

            }


            //second = (30);

            breathingActivity.SetDuration(30);
            //Console.ReadLine(breathingActivity.SetDuration());

        }
        else if(choice == "2")
        {
            ReflectionActivity reflectionActivity = new ReflectionActivity();
            reflectionActivity.SetName("Welcome To The Reflective Activity");
            reflectionActivity.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            
            Console.WriteLine();
            Console.WriteLine(reflectionActivity.GetName());
            Console.WriteLine();
            Console.WriteLine(reflectionActivity.GetDescription());
            Console.WriteLine();


            Console.Write("How long would you want to take this activity: ");
            string secondsInput = Console.ReadLine();
        
            int seconds = int.Parse(secondsInput);
            if (seconds != 0)
            {
                Console.WriteLine("Get Ready");
                List<string> animationstring = new List<string>();
                animationstring.Add("|");
                animationstring.Add("/");
                animationstring.Add("-");
                animationstring.Add("\\");
                animationstring.Add("|");
                animationstring.Add("/");
                animationstring.Add("-");
                animationstring.Add("\\");
                foreach (string s in animationstring)
                {
                    
                    //Console.WriteLine();
                    //Console.WriteLine("Out");
                    Console.Write(s);
                
                    Thread.Sleep(1000);

                    Console.Write("\b \b");

                }

                Console.WriteLine();
                Console.WriteLine("Consider the following prompt: ");
                Console.WriteLine();
                Console.WriteLine();

            }
        }
        else if(choice == "3")
        {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.SetName("Welcome To the Listing Activity");
                listingActivity.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            
                Console.WriteLine();
                Console.WriteLine(listingActivity.GetName());
                Console.WriteLine();
                Console.WriteLine(listingActivity.GetDescription());
                Console.WriteLine();


                Console.Write("How long would you want to take this activity: ");
                //string secondsInput = Console.ReadLine();
                //int seconds = int.Parse(secondsInput);
        

        }
        else
        {
            Console.WriteLine("Thank you, Play again next time");
        }
            
        

        Console.WriteLine("Done");
    }
}
