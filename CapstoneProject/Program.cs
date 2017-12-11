using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject
{
    //
    // enum
    //
    public enum Hair
    {
        CURLS = 15,
        UPDO = 50,
        HALFUP = 25,
        BUZZED = 10
    }



    class Program
    {
        //*****************************************
        //
        // Title: Capstone Project
        // Aplication Type: Console framework
        // Description: Quote your event hairstyles
        // Author: Chloe Kulanda
        // Date Created: 11-27-17
        // Last Modified:
        //
        //******************************************

        //
        // set up global variables
        //
        static string userResponse;
        static int numberOfPeople; 
        static int quote;
        static int costOfStyle;

        static void Main(string[] args)
        {
            DisplayOpeningScreen();
            DisplayMenu();
            DisplayClosigScreen();
        }

        /// <summary>
        /// get number of poeple
        /// </summary>
        static void DisplayNumberOfPeople()
        {
            DisplayHeader("Number of People");

            Console.WriteLine();
            Console.Write("Enter number of people: ");
            userResponse = Console.ReadLine();
            while (!int.TryParse(userResponse, out numberOfPeople))
            {
                Console.WriteLine();
                Console.WriteLine("It appears you did not enter a valid number");
                Console.WriteLine("Please Try again");
                Console.WriteLine();
                Console.Write("Enter number of people: ");
                userResponse = Console.ReadLine();
            }
        }

        /// <summary>
        /// Select hair style
        /// </summary>
        static void DisplayHairStyleSelection()
        {
            Hair hairStyles;
            DisplayHeader("Hair Style Selection");


            Console.Write("Select your choice of hair style (Curls, Updo, HalfUp, Buzzed): ");
            userResponse = Console.ReadLine().ToUpper();
            Enum.TryParse<Hair>(userResponse, out hairStyles);

            switch (hairStyles)
            {
                case Hair.CURLS:
                    costOfStyle = (int)Hair.CURLS;
                    Console.WriteLine($"You chose {userResponse}");
                    break;
                case Hair.UPDO:
                    costOfStyle = (int)Hair.UPDO;
                    Console.WriteLine($"You chose {userResponse}");
                    break;
                case Hair.HALFUP:
                    costOfStyle = (int)Hair.HALFUP;
                    Console.WriteLine($"You chose {userResponse}");
                    break;
                case Hair.BUZZED:
                    costOfStyle = (int)Hair.BUZZED;
                    Console.WriteLine($"You chose {userResponse}");
                    break;
                default:
                    Console.WriteLine("Sorry, you chose an invalid option");
                    break;
            }

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display calculate & display quote
        /// </summary>
        static void DisplayQuote()
        {           
            DisplayHeader("Your Quote");

            quote = numberOfPeople * costOfStyle;

            Console.WriteLine($"Your quote is ${quote}.");

            DisplayContinuePrompt();
        }


        /// <summary>
        /// display menu
        /// </summary>
        static void DisplayMenu()
        {
            string menuChoice;
            bool exiting = false;

            while (!exiting)
            {
                DisplayHeader("Main Menu");

                Console.WriteLine("\tA) Select Hair Style");
                Console.WriteLine("\tB) Get Number Of People");
                Console.WriteLine("\tC) Get Quote");
                Console.WriteLine("\tD) Exit");


                Console.Write("Enter Choice: ");
                menuChoice = Console.ReadLine().ToUpper();

                switch (menuChoice)
                {
                    case "A":
                        DisplayHairStyleSelection();
                        break;
                    case "B":
                        DisplayNumberOfPeople();
                        break;
                    case "C":
                        DisplayQuote();
                        break;
                    case "D":
                        exiting = true;
                        break;
                    default:
                        break;
                }

            }

        }


        /// <summary>
        /// display opening screen
        /// </summary>
        static void DisplayOpeningScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\t\t Capstone Project");
            Console.WriteLine();
            Console.WriteLine("In this project I will be giving you a quote for how much your hairstyle is");
            Console.WriteLine("depending on the hairstyle and how many people.");

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display header
        /// </summary>
        /// <param name="headerTitle"></param>
        static void DisplayHeader(string headerTitle)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t\t" + headerTitle);

        }

        /// <summary>
        /// display closing screen
        /// </summary>
        static void DisplayClosigScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\t\tThank You, have a nice day!");
            Console.WriteLine();

            Console.WriteLine("press any key to exit.");
            Console.ReadKey();
        }
    }
}
