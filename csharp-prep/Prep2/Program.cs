using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage (no decimal points): ");
        string gradeInText = Console.ReadLine();
        int gradePercentage = int.Parse(gradeInText);

        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";

        }
        else if (gradePercentage >= 80)
        {
            letter ="B";
        }
        else if (gradePercentage >= 70)
        {
            letter ="C";
        }
        else if (gradePercentage >= 60)
        {
            letter ="D";
        }
        else
        {
            letter ="F";
        }
            Console.WriteLine($"Your grade is {letter}.");
        
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the class.");
        }
        else
        {
            Console.WriteLine("Unfortunately you did not pass, best luck next time!");
        }
    }
}