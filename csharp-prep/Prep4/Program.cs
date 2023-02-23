using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumbers = -1;
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        while (newNumbers != 0)
        {
            Console.Write("Enter Number: ");
            newNumbers = int.Parse(Console.ReadLine());
            if (newNumbers != 0)
            {
               numbers.Add(newNumbers); 
            }
        }
        int sum = 0;
        int largeNumber = numbers[0];
        foreach (int number in numbers)
        {
            sum += number;
            if (largeNumber < number)
            {
                largeNumber = number;
            }
        }
        Console.WriteLine($"The sum is {sum} ");  
        float average = (float)sum/numbers.Count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largeNumber}");
        
    }
}