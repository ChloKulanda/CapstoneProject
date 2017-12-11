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
        CURLS,
        UPDO,
        HALFUP,
        BUZZED
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
        static Hair hairStyles;


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

            Console.Write("Please enter the number of people getting their hair done:  ");
            userResponse = Console.ReadLine();

            DisplayContinuePrompt();
        }

        static void DisplayAllHairStyles()
        {
            //foreach (var item in collection)
            //{

            //}
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

                Console.WriteLine("\tA) Get Number of People");
                Console.WriteLine("\tB) ");
                Console.WriteLine("\tC) ");
                Console.WriteLine("\tD) ");
                Console.WriteLine("\tE) ");
                Console.WriteLine("\tF) ");
                Console.WriteLine("\tG) Exit");


                Console.Write("Enter Choice: ");
                menuChoice = Console.ReadLine().ToUpper();

                switch (menuChoice)
                {
                    case "A":
                        DisplayNumberOfPeople();
                        break;
                    case "B":

                        break;
                    case "C":

                        break;
                    case "D":

                        break;
                    case "E":

                        break;
                    case "F":

                        break;

                    case "G":
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
            Console.WriteLine("In this project I will be giving you a quote for how much your hairstyle for your event will be");
            Console.WriteLine("depending on the hairstyle(s) and how many people.");

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
            Console.WriteLine("\t\t\tThat's it Folks");
            Console.WriteLine();

            Console.WriteLine("press any key to exit.");
            Console.ReadKey();
        }
    }
}
