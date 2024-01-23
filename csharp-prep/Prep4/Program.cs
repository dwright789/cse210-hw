using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        int totalSum= 0;
        int count = 0;
        int largestNumber = 0;
        
        //create a list called numbersList
        List<int> numbersList = new List<int>();
        
        //ask user for a number
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            //convert user answer to an integer
            number = int.Parse(Console.ReadLine());
            //add user number to the list
            if (number != 0)
            {
                numbersList.Add (number);
                count += 1;
                //Console.WriteLine (count);
            }
        }
    
        
        foreach (int eachNum in numbersList)
        {
            totalSum += eachNum;
        }
        Console.WriteLine($"The total sum is: {totalSum}");
        
        foreach (int eachNum in numbersList)
        {
            if (eachNum > largestNumber)
            {
                largestNumber = eachNum;
            }
        }
        
        
        float average = ((float)totalSum)/count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine ($"The largest number is: {largestNumber}");
        
        
    }
    
    
}