using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string userName = PromptsUserName();
        int userNumber = PromptUserNumber();
        int numberSquared = SquareNumber(userNumber);

        DisplayResult(userName,numberSquared);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
        
    static string PromptsUserName()
    {            
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string favoirteNumber = Console.ReadLine();
        int userNumber = int.Parse(favoirteNumber);
        return userNumber;
    }

    static int SquareNumber(int userNumber)
    {
        int numberSquared = userNumber * userNumber;
        return numberSquared;
    }

    static void DisplayResult(string userName, int numberSquared)
    {
        Console.Write($"{userName}, your favorite number squared is {numberSquared}");
    }
}