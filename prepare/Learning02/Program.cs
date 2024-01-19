using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");


        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Curo365";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Quality Assurance Engineer";
        job2._company = "Microsoft";
        job2._startYear = 2022;
        job2._endYear = 2023;

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();
       

    
    }

   

}