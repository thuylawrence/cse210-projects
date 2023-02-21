using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Enter your grade: ");
        string gradeLetter = Console.ReadLine();
        int number = int.Parse(gradeLetter);
        string grade = "";

        if (number >=90)
        {
            grade = "A";
        }
        else if (number >= 80)
        {
            grade = "B";
        }
        else if (number >= 70)
        {
            grade = "C";
        }
        else if (number >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        Console.WriteLine($"Your grade is: {grade}");

        if (number >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Good luck next time!");
        }

        
    }
}