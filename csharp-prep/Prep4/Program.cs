using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        

        int userNumber = -1;

        List<int> numberList = new List<int>();
        

        while(userNumber != 0)

        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0 )
            {
                numberList.Add(userNumber);
            }
        }
            //Sum numbers in the list
        int sum = 0;
        
        foreach(int number in numberList)
        {
            sum += number;
        }
        Console.WriteLine($"The total sum is: {sum}");
            // Calculate Average
        float average = 0;
        average = sum / numberList.Count;

        Console.WriteLine($"The average is: {average}");

            // Check for Max number
            int max = numberList[0];

            foreach (int number in numberList)
            {
                if (number > max)
                {
                    max = number;
                }
            }

        Console.WriteLine($"The maximum number in the list is: {max}");


           

            

            

        

        
           

        

            

    }
}