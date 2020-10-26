using System;

namespace rockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int computerRounds = 0;
            int userRounds = 0;

            //print round text

            for (int i = 0; i < 3; i++)
            {
                int computerWins = 0;
                int userWins = 0;

                Console.WriteLine($"Round {i + 1}");

                for (int ii = 0; ii < 3; ii++)
                {
                    // random computer selection Random.Next Method overload
                    Random random = new Random();

                    //Next(Int32)  Returns a non-negative random integer that is less than the specified maximum.
                    int computerSelection = random.Next(3);

                    // user selection if, else, switch, case
                    Console.WriteLine($"Rock, paper or scissors?");
                    string userInput = Console.ReadLine();

                    // makes user selection lowercase ToLower() is a string method
                    string userSelection = userInput.ToLower();

                    // case 0 computer == "rock" user has three possiable outcome C# Comparison Operators ==	Equal to
                    if (computerSelection == 0 && userSelection == "rock\n")
                    {
                        Console.WriteLine("Computer threw rock.\nIt's a draw!\n");
                    }
                    else if (computerSelection == 0 && userSelection == "scissors\n")
                    {
                        Console.WriteLine("Computer threw rock.\nYou lost!\n");
                        computerWins++;
                    }
                    else 
                    {
                        Console.WriteLine("Computer threw rock.\nYou won!\n");
                        userWins++;
                    }

                    // case 1 computer == "paper" user has three possiable outcome
                    if (computerSelection == 1 && userSelection == "rock\n")
                    {
                        Console.WriteLine("Computer threw paper.\nYou lost!\n");
                        computerWins++;
                    }
                    else if (computerSelection == 1 && userSelection == "paper\n")
                    {
                        Console.WriteLine("Computer threw paper.\nIt's a draw!\n");
                    }
                    else 
                    {
                        Console.WriteLine("Computer threw paper.\nYou won!\n");
                        userWins++;
                    }

                    // case 2 comnputer == "scissors user has three possiable outcome
                    if (computerSelection == 2 && userSelection == "rock\n")
                    {
                        Console.WriteLine("Computer threw scissors.\nYou won!\n");
                        userWins++;
                    }
                    else if (computerSelection == 2 && userSelection == "paper\n")
                    {
                        Console.WriteLine("Computer threw scissors.\nYou lost!\n");
                        computerWins++;
                    }
                    else 
                    {
                        Console.WriteLine("Computer threw scissors.\nIt's a draw!\n");
                    }
                }

                if (computerWins == userWins)
                {
                    Console.WriteLine("It's a draw!\n");
                }
                else if (computerWins > userWins)
                {
                    Console.WriteLine("Computer won this round!\n");
                    computerRounds++;
                }
                else 
                {
                    Console.WriteLine("You won this round!\n");
                    userRounds++;
                }

                Console.ReadLine();
            }

            if (computerRounds > userRounds)
            {
                Console.WriteLine("Computer won the game...\n");
            }
            else if (computerRounds < userRounds)
            {
                Console.WriteLine("You won the game!\n");
            }
            else 
            {
                Console.WriteLine("The game was a draw...\n");
            }
        }
    }
}