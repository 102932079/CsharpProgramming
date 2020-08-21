using System;
using System.Collections.Generic;


namespace AT1_BingoNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Upon starting the program should ask for the upper limit of numbers to be drawn
            int Limit = 0;
            //create two list for later use  two ways of print out list
            List<int> OrderList = new List<int>();
            List<int> SortList = new List<int>();

            //set up checklimt defalut to false
            bool CheckLimit = false;

            System.Console.WriteLine("Set up limit (1-99)");

                while (!CheckLimit)
                {
                    string input1 = Console.ReadLine();

                    //Program should not accept non-numeric input -Out parameter can pass without its declaration and initialization3
                    // input from string into int
                    if (int.TryParse(input1, out Limit))
                    {
                        //Program should not accept negative numbers and with the limit
                        if (Limit >= 0 && Limit < 99 )
                        {
                            CheckLimit = true;
                        }

                        else
                        {
                            System.Console.WriteLine(" Enter Number (1-99)");
                        }
                    }

                    else
                    {
                        System.Console.WriteLine(" Numeric only (1-99)");

                    }
                }

            System.Console.WriteLine($"Out of Range 1 - {Limit}");

            //=======================================================================================================

            //Task menu set up input2 for detact user selection 

            int input2 = 0;

            //all four menu option

            while ( input2 != 4 )
            {
                System.Console.WriteLine(" Welcome to the Swinburne Bingo Club");
                System.Console.WriteLine(" 1. Draw next number ");
                System.Console.WriteLine(" 2. View all drawn numbers ");
                System.Console.WriteLine(" 3. Check specific number ");
                System.Console.WriteLine(" 4. Exit ");

                // set up checkinput defalut to false

                bool CheckInput = false;

                //limit the option 

                while (!CheckInput)
                {
                    string user = Console.ReadLine();
                    //Out parameter can use var type in the method parameter list.

                    if (int.TryParse(user, out input2))
                    {
                        //Selection meanful
                        if (input2 >=0 && input2 < 4)
                        {
                            CheckInput = true;                        
                        }

                        else 
                        {
                            System.Console.WriteLine("Invalid option");
                        }

                    }

                    else
                    {
                        System.Console.WriteLine("Invalid option");
                    }
                }

                //========================================================================================
                //set up draw next number function -Upon pressing “1” a new number is drawn

                if (input2 == 1)
                {
                    //create an instance for random from 1 to limit - No negative numbers should be drawn

                    Random rand = new Random();
                    int RNG = rand.Next(1, Limit);

                    //check orderlist has rng - No duplicate numbers should be drawn

                    if(OrderList.Contains(RNG))
                    {
                        System.Console.WriteLine("Duplicate, Try again.");
                    }

                    else
                    {
                        //display the RNG number
                        System.Console.WriteLine($"Drawn number is {RNG}");

                        //add RNG in both list for later use
                        OrderList.Add(RNG);
                        SortList.Add(RNG);

                    }
                }

                //===========================================================================================
                //show all drawn number function

                else if (input2 ==2 )
                {
                    //create another input 3 for sub menu option
                    int input3 = 0;

                    System.Console.WriteLine("1. Print all numbers in the order that they were drawn:");
                    System.Console.WriteLine("2. Print all numbers in numerical order: ");

                    //set up Checkoption to make selection meanful

                    bool CheckOption = false;

                    while (!CheckOption) 
                    {
                        string option = Console.ReadLine();

                        //It is not obligatory that Out parameter name should be same in both function definition and call.

                        if (int.TryParse(option, out input3))
                        {
                            // make selection meanful
                            if (input3 >= 1 && input3 <= 4)
                            {
                                CheckOption = true;
                            }

                            else
                            {
                                System.Console.WriteLine("Invalid option");

                            }
                        }

                        else
                        {
                            System.Console.WriteLine("Invalid option");
                        }

                    }
                    //create the sub menu for print out list function
                    //Provide an option to print all numbers in the order that they were drawn

                    if (input3 == 1)
                    {
                        //display the title
                        System.Console.WriteLine("Number in drawn order");

                        //foreach for display list element

                        foreach (int num1 in OrderList)
                        {
                            Console.WriteLine(num1 + " ");
                        }
                    }
                    //Provide an option to print all numbers in numerical order
                    
                    else if ( input3 == 2 )
                    {
                        System.Console.WriteLine("Number in numerical order");

                        //sort() method to arrange the list

                        SortList.Sort();

                        //display number in list

                        foreach (int num2 in SortList)
                        {
                            System.Console.WriteLine(num2 + " ");
                        }

                    }

                    // set limit for option

                    else
                    {
                        //System.Console.WriteLine("===============");
                        System.Console.WriteLine("Invalid option");
                    }         

                }

                //Check specific number function
                else if (input2 == 3 )
                {

                    
                    int input4 = 0;

                    System.Console.WriteLine("Enter a number");

                    // create a input for checking spcific number
                    //need set up a range 1- limitinput

                    string search = Console.ReadLine();

                    if (int.TryParse(search, out input4))
                    {
                        if (OrderList.Contains(input4))
                        {
                            System.Console.WriteLine($"{search} has been drawn.");
                        }

                        else
                        {
                            System.Console.WriteLine($"{search} has NOT been drawn.");

                        }
                    }

                    else
                    {
                        System.Console.WriteLine("Invalid option");
                    }


                }

                //==============================================================================================
                //exit function
            


                else if  ( input2 == 4 )
                {

                    System.Console.WriteLine("Program Exit");

                    Console.ReadKey();

                    //he break statement terminates the closest enclosing loop or switch statement in which it appears. Control is passed to the statement that follows the terminated statement, if any.

                    
                }
             }     

        }
    }

}

