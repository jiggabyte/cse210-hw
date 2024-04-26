using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");
        /*
            For this assignment, write a C# program that has several simple functions:

            DisplayWelcome - Displays the message, "Welcome to the Program!"
            PromptUserName - Asks for and returns the user's name (as a string)
            PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
            SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
            DisplayResult - Accepts the user's name and the squared number and displays them.
            Your Main function should then call each of these functions saving the return values and passing data to them as necessary.

            Sample output of the program could look as follows:


            Welcome to the program!
            Please enter your name: Brother Burton
            Please enter your favorite number: 42
            Brother Burton, the square of your number is 1764

        */

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();

        int favNumber = SquareNumber(number);

        // Print information
        DisplayResult(name,favNumber);



    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }


    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

        static int SquareNumber(int number)
    {
        return (int)Math.Pow(number,2);
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }

}