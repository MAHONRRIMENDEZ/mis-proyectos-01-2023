using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your current grade percentage? ");
        String userGrade = Console.ReadLine();
        int percent = int.Parse(userGrade);
     
            string userGradeLetter = "";

            if (percent >= 90 && percent < 101);
            {
                userGradeLetter = "A";
            } 
            else if (percent >= 80)
            {
                 userGradeLetter = "B";
            }
            else if (percent >= 70)
            {
                userGradeLetter = "C";
            }
            else if (percent >= 60)
            {
                userGradeLetter = "D";
            }
            else
            {
                userGradeLetter = "F";
            }

            Console.WriteLine($"Your grade is: {letter}");
            
            if (percent >= 70)
            {
                Console.WriteLine("Congrats You've approved!");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }
    }
}