using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumberGenerator = new Random();
        int number = randomNumberGenerator.Next(1,100);
        int guess = -1;

        while (guess != number)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (guess < number)
            {
                Console.WriteLine("higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("lower");
            }
            else
            {
                Console.WriteLine("Congratulations you guessed it!");
            }
        }
    }
}