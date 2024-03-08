using System;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        float addNumber = -1;
        while (addNumber != 0)
        {
            Console.WriteLine("Enter number:");
            string userNumber = Console.ReadLine();
            addNumber = float.Parse(userNumber);
            if (addNumber != 0)
            {
                numbers.Add(addNumber);
            }
        }

        float sum = 0;
        foreach (float number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        float maxNumber = 0;
        foreach (float number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}