using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");

        // Print welcome info
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // initiate variables
        int number = -1;
        float sum = 0;
        float avg = 0;
        int maxNumber = 0;
        List<int> numList = new List<int>();

        while (number != 0)
        {

            // Prompt user
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numList.Add(number);

        }

        sum = numList.Sum();

        avg = (float)sum/numList.Count;

        maxNumber = numList.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {maxNumber}");

        numList.Sort();
        int minPositive = 0;

        foreach(int num in numList)
        {
            if(num <= 0)
            {

            }
            else
            {
                minPositive = num;
                break;
            }
        }

        Console.WriteLine($"The smallest positive number is: {minPositive}");
        Console.WriteLine("The sorted list is: ");
        foreach(int num in numList)
        {
            Console.WriteLine($"{num}");
        }




    }
}