using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
       
        int userNumber = PromptUserNumber();

        int square = SquareNumber(userNumber);

        DisplayResults(userName, square);
    }
    
    static void DisplayWelcome()
    {   
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is you name? ");
        string username = Console.ReadLine();
        return username;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResults(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}.");
    }   
}