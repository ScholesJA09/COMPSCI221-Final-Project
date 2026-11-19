using System;

namespace COMPSCI221_Final_Project
{
    static class FinalProject
    {
        static void PrintAll()
        {

        }

        static void PrintPC()
        {

        }

        static void PrintConsole()
        {

        }

        static void PrintHandheld()
        {

        }

        static void PrintDeveloper()
        {

        }

        static void SortRating()
        {

        }

        static void SortYear()
        {

        }

        static void SortTitle()
        {

        }

        static void PrintYear()
        {

        }

        static void PrintGenre()
        {

        }

        static void Main()
        {
            string path = "Video_Game_Collection.csv";
            int input = 0;
            while (input != 11) //Loop until user inputs to quit
            {
                //Listing out commands
                Console.WriteLine("Enter the corresponding number to execute the following command:");
                Console.WriteLine("(1) Print out all video games");
                Console.WriteLine("(2) Print out all PC video games");
                Console.WriteLine("(3) Print out all console video games");
                Console.WriteLine("(4) Print out all handheld video games");
                Console.WriteLine("(5) Print out all video games given developer");
                Console.WriteLine("(6) Sort all video games by rating");
                Console.WriteLine("(7) Sort all video games by release year");
                Console.WriteLine("(8) Sort all video games by title");
                Console.WriteLine("(9) Print out all video games released on or after given year");
                Console.WriteLine("(10) Print out all video games given genre");
                Console.WriteLine("(11) Quit");
                Console.WriteLine();

                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (Exception e) //Parse failed
                {
                    Console.WriteLine($"[Error]: {e.Message}");
                }

                switch (input)
                {
                    case (int)Input.PrintAll: //Command 1
                        PrintAll();
                        break;
                    case (int)Input.PrintPC: //Command 2
                        PrintPC();
                        break;
                    case (int)Input.PrintConsole: //Command 3
                        PrintConsole();
                        break;
                    case (int)Input.PrintHandheld: //Command 4
                        PrintHandheld();
                        break;
                    case (int)Input.PrintDeveloper: //Command 5
                        PrintDeveloper();
                        break;
                    case (int)Input.SortRating: //Command 6
                        SortRating();
                        break;
                    case (int)Input.SortYear: //Command 7
                        SortYear();
                        break;
                    case (int)Input.SortTitle: //Command 8
                        SortTitle();
                        break;
                    case (int)Input.PrintYear: //Command 9
                        PrintYear();
                        break;
                    case (int)Input.PrintGenre: //Command 10
                        PrintGenre();
                        break;
                    case (int)Input.Quit: //Command 11
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Must be 1-11!\n"); //Input out of range
                        break;
                }
            }
        }
    }
}