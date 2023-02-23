using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);
    }

    private static void DisplayResult(string userName, int squareNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
    }

    private static int SquareNumber(int userNumber)
    {
        int square = userNumber * userNumber;
        return square;
    }

    private static int PromptUserNumber()
    {
        int userNumber;
        Console.Write("Please enter your favorite number: ");
        userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    private static string PromptUserName()
    {
        string userName;
        Console.Write("Please enter your name: ");
        userName = Console.ReadLine();
        return userName;
    }

    private static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program! ");

    }
}