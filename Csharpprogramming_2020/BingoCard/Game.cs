using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

//The System.Linq namespace provides classes and interfaces that support queries that use Language-Integrated Query (LINQ).

namespace BingoCard
{
    public class Game
    {
        public string PlayerName;
        public Player player;
        public int userBoardSize;
        public Game()
        {
            this.userBoardSize = 0;
            this.PlayerName = "";
        }

        public void startMenu()
        {
            player = new Player();
            
            Console.WriteLine("Bingo Games");
            
            Console.WriteLine("Please enter your name ");

            player.PlayerName = Console.ReadLine();

            Console.WriteLine("Welcome " + player.PlayerName + ". Please enter your selection");
            Console.WriteLine("1. Create New Bingo Card");
            Console.WriteLine("2. Exit");

            int userinput = Convert.ToInt32(Console.ReadLine());

            if (userinput == 1)
            {
                createCardMenu();
            }
            else if (userinput == 2)
            {
                Console.Write("So you have chosen death....");
                return;
            }
        }

        public void createCardMenu()
        {
            Console.WriteLine("To create your card please enter the size of the board");
            Console.WriteLine("the board size must be a sqaure number for the board to be created");
            Console.WriteLine("For example 2x2 = 4, 3x3 = 9, 4x4 = 16, 5x5 = 25, etc...");
            Console.WriteLine("The actual numbers on the card are seqential from 1 - max number available per card");
            Console.WriteLine("Now please enter your board size");
            userBoardSize = Convert.ToInt32(Console.ReadLine());
            var truth = isSqr(userBoardSize);

            if (truth)
            {
                Console.WriteLine("Please enter the smallest number in range");
                int minRange = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the largest number in range");
                int maxRange = Convert.ToInt32(Console.ReadLine());

                player.AddCard(userBoardSize, minRange, maxRange);/// here we attch all the data we need for the card to the player
                ShowCardGrid(); //// here the userboard size the user puts in gets passed to the showcard grid method.

                // game has a player member with a card member which has all valid numbers in the range the user has inputted

                bool continuePlaying = true;
                bool isGameFinished = false;

                Console.WriteLine("\nWould you like to mark a number off your card or exit? ");

                while (continuePlaying == true && isGameFinished == false)
                {                    
                    Console.WriteLine("\n1. Mark a number off your Bingo Card");
                    Console.WriteLine("\n2. Exit");
                    int userinput = Convert.ToInt32(Console.ReadLine());

                    if (userinput == 1)
                    {
                        Console.WriteLine("Enter your number to mark off ");
                        string targetInt = Console.ReadLine();

                        int index = player.card.CardNumbers.IndexOf(targetInt);
                        if (index > 0)
                        {
                            player.card.CardNumbers[index] = "X";
                            ShowCardGrid();

                            var numberOfXinList = player.card.CardNumbers.Where(a => a == "X").Count();

                            if (numberOfXinList == userBoardSize)
                            {
                                isGameFinished = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Your number does not exist in the card - please try again");
                        }
                    }
                    else if (userinput == 2)
                    {
                        Console.Write("So you have chosen death....");
                        continuePlaying = false;
                    }
                }
                
                if (isGameFinished == true)
                {
                    Console.WriteLine("Congratulations you've won the bingo game!");
                }
                else if (continuePlaying == false)
                {
                    Console.WriteLine("Better luck next time!");
                }
            }
            else
            {
                Console.WriteLine("Your number was not a sqaure");//// sort o the error catch and takes them back to the top again.
                createCardMenu();
            }
        }

        public void ShowCardGrid()  // gridsize was 16
        {
            double squareRoot = Math.Sqrt(userBoardSize);     // 4

            //player.card.cardNums is a list of all the numbers 

            int index = 0;

            for (int y = 0; y < squareRoot; y++)
            {
                bool isFirst = true;

                for (int x = 0; x < squareRoot; x++)
                {
                    if (isFirst == true)
                    {
                        Console.Write("\n" + player.card.CardNumbers[index]);
                        isFirst = false;
                    }
                    else
                    {
                        Console.Write("\t" + player.card.CardNumbers[index]);
                    }

                    index++;
                }
            }


        }

        public bool isSqr(int num)
        {
            // get the square root WITH any fractional component 
            double sq1 = Math.Sqrt(num);

            // get square root with fraction truncated by casting as an int
            int sq2 = (int)Math.Sqrt(num);

            // compare the numbers as doubles and see if equal
            // if the fraction part of sq1 was zero (perfect square), then 
            // the int and the double will be equivalent
            if (sq1 == (double)sq2)
                return true;
            return false;

        }

    }

}