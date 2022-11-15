using System;

public class RPS
{
    public static void Main(string[] args)
    {
        string answer = "";
        int counter = 0;
        int counter1 = 0;

        Console.WriteLine("Welcome to Rock, Paper and Scissor game");

        while (answer == "" || answer == "YES" || answer == "Y")
        {
            Console.WriteLine("Select any one:\n1> ROCK\n2> PAPER\n3> SCISSOR");
            string[] computer_choices = new string[3] { "ROCK", "PAPER", "SCISSOR" };
            Random rnd = new Random();
            int n = rnd.Next(0, 3);
            Console.WriteLine("Enter your choice:");
            string user_choices = Console.ReadLine().ToUpper();
            Console.WriteLine("Computer:" + computer_choices[n]);

            if (user_choices == "ROCK" && computer_choices[n] == "SCISSOR")
            {
                Console.WriteLine("User wins");
                counter += 1;
            }
            else if (user_choices == "ROCK" && computer_choices[n] == "PAPER")
            {
                Console.WriteLine("Computer wins");
                counter1 += 1;
            }
            else if (user_choices == "PAPER" && computer_choices[n] == "ROCK")
            {
                Console.WriteLine("User wins");
                counter += 1;
            }
            else if (user_choices == "PAPER" && computer_choices[n] == "SCISSOR")
            {
                Console.WriteLine("Computer Wins");
                counter1 += 1;
            }
            else if (user_choices == "SCISSOR" && computer_choices[n] == "ROCK")
            {
                Console.WriteLine("Computer Wins");
                counter1 += 1;
            }
            else if (user_choices == "SCISSOR" && computer_choices[n] == "PAPER")
            {
                Console.WriteLine("User wins");
                counter += 1;
            }
            else
            {
                Console.WriteLine("Same choices");
            }
            Console.WriteLine("Do you want to continue(YES/NO):");
            answer = Console.ReadLine().ToUpper();
            Console.WriteLine("---------------------------------------");
        }
        Console.WriteLine("User wins " + counter + " times");
        Console.WriteLine("Computer wins " + counter1 + " times");
    }
}

