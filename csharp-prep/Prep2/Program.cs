using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the number percent of your grade? ");
        string stringGrade = Console.ReadLine();

        Boolean passConf;

        if (int.TryParse(stringGrade, out int grade))
        {
            if (grade >= 90)
            {
                Console.WriteLine("Your grade is an A! Congrats!");
                passConf = true;
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Your grade is a B. You did a great job!");
                passConf = true;
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Your grade is a C. Good work!");
                passConf = true;
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Your grade is a D.");
                passConf = false;
            }
            else
            {
                Console.WriteLine("Your grade is an F.");
                passConf = false;
            }
            if (passConf == true)
            {
                Console.WriteLine("You passed the class!");
            }
            else if (passConf == false)
            {
                Console.WriteLine("You got this! Either shape up or take the class again!");
            }
        }
    }
}