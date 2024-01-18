using System;

class Program
{
    static void Main(string[] args)
    {
        //ask user for grade percentage and then determine which letter grade it is
        Console.Write("What is your grade percentage? ");

        //create variable for user input
        string userInput = Console.ReadLine();

        //create variable and convert user input string to an integer
        int grade_percentage = int.Parse(userInput);

        //create variable to hold letter grade
        string letter = "";

        //determine which letter grade and print statement according to which grade.
        if (grade_percentage >= 90)
        {
            //Console.WriteLine("You have an A.");
            letter = "A";

        }
        else if (grade_percentage >= 80)
        {
            //Console.WriteLine("You have a B.");
             letter = "B";
        }
        else if (grade_percentage >= 70)
        {
            //Console.WriteLine("You have a C.");
             letter = "C";
        }
        else if (grade_percentage >= 60)
        {
            //Console.WriteLine("You have a D.");
             letter = "D";
        }
        else
        {
            //Console.WriteLine("You have an F.");
             letter = "F";
        }

        //print the letter grade
        Console.WriteLine($"You have a/an {letter}.");
        
        //determine if they passed the class and print corresponding statement
        if (grade_percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("You didn't pass the class. Keep trying. You've got this!");   
        }
    }
}