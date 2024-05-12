using System;

/*
Submission Comment:

I added a 2D string array containing a list of scripture references
which my code randomly selects one to use for the scripture memorizer.

*/
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        
        string[,] scriptureData =  {
                                        {"John", "3", "16", "", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."},
                                        {"Psalm", "23", "1", "", "The Lord is my shepherd, I lack nothing."},
                                        {"Proverbs", "3", "5", "6", "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."},
                                        {"Philippians", "4", "13", "", "I can do all this through him who gives me strength."},
                                        {"Romans", "8", "28", "", "And we know that in all things God works for the good of those who love him, who have been called according to his purpose."},
                                        {"Matthew", "6", "33", "", "But seek first his kingdom and his righteousness, and all these things will be given to you as well."},
                                        {"Isaiah", "40", "31", "", "But those who hope in the Lord will renew their strength. They will soar on wings like eagles; they will run and not grow weary, they will walk and not be faint."},
                                        {"1 Corinthians", "13", "4", "7",  "Love is patient, love is kind. It does not envy, it does not boast, it is not proud. It does not dishonor others, it is not self-seeking, it is not easily angered, it keeps no record of wrongs. Love does not delight in evil but rejoices with the truth. It always protects, always trusts, always hopes, always perseveres."},
                                        {"Galatians", "5", "22", "23", "But the fruit of the Spirit is love, joy, peace, forbearance, kindness, goodness, faithfulness, gentleness and self-control. Against such things there is no law."},
                                        {"2 Timothy", "1", "7", "", "For the Spirit God gave us does not make us timid, but gives us power, love and self-discipline."}

                                    };

        int BOOK_NAME = 0;
        int CHAPTER_INDEX = 1;
        int VERSE_INDEX = 2;
        int ENDVERSE_INDEX = 3;
        int VERSE_TEXT = 4;        

        List<List<string>> scriptureLoader = new List<List<string>>();
        
        for(int i = 0; i < scriptureData.GetLength(0); i++)
        {
            List<string> scriptText = new List<string>();
            for(int j = 0; j < scriptureData.GetLength(1); j++)
            {

                scriptText.Add(scriptureData[i,j]);
                
            }

            scriptureLoader.Add(scriptText);

        }        

        ConsoleKeyInfo keyInfo;
        string programExit;

        // Create a reference
        Reference reference;

        // Create a scripture
        string scriptureText;
        Scripture scripture;

        Console.Clear();
        Console.WriteLine("Press Enter to continue or Type 'quit' to exit!");

        // Create an instance of Random class
        Random random = new Random();

        // Generate a random index for selecting a scripture from the list
        int randomIndex = random.Next(0, scriptureLoader.Count);

        // Get the scripture text at the randomly generated index
        List<string> selectedScripture = scriptureLoader[randomIndex];

        if(selectedScripture[ENDVERSE_INDEX] == "")
        {
        // Create a reference
        reference = new Reference(selectedScripture[BOOK_NAME], Int32.Parse(selectedScripture[CHAPTER_INDEX]), Int32.Parse(selectedScripture[VERSE_INDEX]));

        }
        else
        {
        // Create a reference
        reference = new Reference(selectedScripture[BOOK_NAME], Int32.Parse(selectedScripture[CHAPTER_INDEX]), Int32.Parse(selectedScripture[VERSE_INDEX]), Int32.Parse(selectedScripture[ENDVERSE_INDEX]));

        }


        // Create a scripture
        scriptureText = selectedScripture[VERSE_TEXT];
        scripture = new Scripture(reference, scriptureText);

        do {

            // Read the next key pressed by the user
            programExit = "";
            keyInfo = Console.ReadKey();

            // Check if the pressed key is Enter
            if (keyInfo.Key == ConsoleKey.Enter)
            {


                // Hide some random words
                scripture.HideRandomWords(5);

                // Display the scripture
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("Press Enter to continue or Type 'quit' to exit!");

                if(scripture.IsCompletelyHidden())
                {
                    // programExit = "quit";
                    break;
                }

            }
            else if(keyInfo.Key == ConsoleKey.Q)
            {
                programExit = "q" + Console.ReadLine();
                if(programExit.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Press Enter to continue or Type 'quit' to exit!");
                    continue;
                }
            }
            else
            {
                Console.WriteLine("\nYou did not press the Enter key or typed \"quit\" to end program.");
            }


        } while(programExit.ToLower() != "quit");

        Console.WriteLine("Thanks for using The Scripture Memorizer!");
        
            

    }


}