using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");
        string gradePercentageString;
        int gradePercentage;
        string grade;
        string gradeSign;
        Console.Write("What is your grade percentage? ");
        gradePercentageString = Console.ReadLine();
        gradePercentage = int.Parse(gradePercentageString);

        if (gradePercentage >= 90)
        {
            grade = "A";
        }
        else if (gradePercentage >= 80)
        {
            grade = "B";
        }
        else if (gradePercentage >= 70)
        {
            grade = "C";
        }
        else if (gradePercentage >= 60)
        {
            grade = "D";
        }
        else if (gradePercentage < 60)
        {
            grade = "F";
        }
        else 
        {
            grade = "";
        }

        if(int.Parse(gradePercentageString.Substring(gradePercentageString.Length - 1,1)) >= 7)
        {
            if (grade == "F" || grade == "A")
            {
                gradeSign = "";
            }
            else
            {
                gradeSign = "+";
            }
            
        }
        else if(int.Parse(gradePercentageString.Substring(gradePercentageString.Length - 1,1)) < 3)
        {
            if (grade == "F")
            {
                gradeSign = "";
            }
            else
            {
                gradeSign = "-";
            }
           
        }
        else
        {
            gradeSign = "";
        }


        if (gradePercentage >= 70)
        {
            Console.WriteLine($"Congratulations! You passed with a grade of {grade}{gradeSign}");
        }
        else
        {
            Console.WriteLine($"You failed with a grade of {grade}, but you can always try again and be better.");
        }



    }
}