using System;

class Program
{
    static void Main(string[] args)
    {
        //generate a random number
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);
        
        //creating guess variable to get into the while loop
        int guess = -1;
        
        while (guess != number)
        {
            //ask user to guess a number
            Console.Write("What is your magic number guess? ");
            //read user input and put info into a string variable called userInput
            
            string userInput = Console.ReadLine();
            //could combine above and next step like this "int guess = int.Parse(Console.ReadLine());"
            //convert string "userInput" variable into a integer variable called guess
            guess = int.Parse(userInput);
                
                if (guess > number)
                    {
                        Console.WriteLine("You need to guess a lower number");
                    }    
                else if (guess < number)
                    {
                        Console.WriteLine("You need to guess a higher number");
                    }
                else
                {
                Console.WriteLine("You guessed it!");
                } 
        
            }
            
        }
        
}
