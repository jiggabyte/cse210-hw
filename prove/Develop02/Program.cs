using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> promptStrings = new List<string>();

        promptStrings.Add("Who was the most interesting person I interacted with today?");        
        promptStrings.Add("What was the best part of my day?");
        promptStrings.Add("How did I see the hand of the Lord in my life today?");
        promptStrings.Add("What was the strongest emotion I felt today?");
        promptStrings.Add("If I had one thing I could do over today, what would it be?");                

        Journal journal = new Journal();

        PromptGenerator promptGenerator = new PromptGenerator(promptStrings);

        string promptData;

        do{

            Console.WriteLine("Welcome to  The JournalBot!");
            Console.WriteLine("Please, select from one of the options below: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            promptData = Console.ReadLine();

            switch (promptData)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"{prompt}");
                    Console.Write("Enter your response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(new Entry(prompt, response, DateTime.Now.ToString()));
                    Console.WriteLine("Entry added.");
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter filename: ");
                    string fileReader = Console.ReadLine();
                    try{
                        journal.LoadFromFile(fileReader);
                        Console.WriteLine($"Journal loaded from {fileReader}.");
                    } catch(Exception ex){
                        Console.WriteLine(ex.Message);
                    } 
                    break;
                case "4":
                    Console.Write("Enter filename: ");
                    string fileWriter = Console.ReadLine();
                    journal.SaveToFile(fileWriter);
                    Console.WriteLine($"Journal saved to {fileWriter}.");
                    break;
                case "5":
                    Console.WriteLine("Exiting program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }


        } while(promptData != "5");







    }
}