using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Collections.Generic;

namespace COMPSCI221_Final_Project
{
    static class FinalProject
    {
        static int GetLineCount(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("File not found.", path);
            }
            int count = 0;
            using StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                reader.ReadLine();
                count++;
            }
            return count;
        }

        static VideoGame[] ReadVideoGamesFromFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("File not found.", path);
            }
            int lineCount = GetLineCount(path);
            VideoGame[] videoGames = new VideoGame[lineCount - 1];
            using StreamReader reader = new StreamReader(path);
            reader.ReadLine();
            for (int i = 0; i < videoGames.Length; i++)
            {
                string line = reader.ReadLine();
                string[] cols = line.Split(',');
                string gameType = cols[0];
                string title = cols[1];
                string developer = cols[2];
                string publisher = cols[3];
                int releaseYear = int.Parse(cols[4]);
                string genre = cols[5];
                string platform = cols[6];
                int averagePlaytime = int.Parse(cols[7]);
                double rating = double.Parse(cols[8]);
                videoGames[i] = new VideoGame(gameType, title, developer, publisher, releaseYear, genre, platform, averagePlaytime, rating);
            }
            return videoGames;
        }

        static void PrintAll(List<VideoGame> videoGames)
        {
            videoGames.ForEach(game => Console.WriteLine(game));
        }

        static void PrintPC(List<VideoGame> videoGames)
        {
            videoGames.ForEach(game =>
            {
                if (game.GameType == "PC")
                {
                    Console.WriteLine(game);
                }
            });
        }

        static void PrintConsole(List<VideoGame> videoGames)
        {
            videoGames.ForEach(game =>
            {
                if (game.GameType == "Console")
                {
                    Console.WriteLine(game);
                }
            });
        }

        static void PrintHandheld(List<VideoGame> videoGames)
        {
            videoGames.ForEach(game =>
            {
                if (game.GameType == "Handheld")
                {
                    Console.WriteLine(game);
                }
            });
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
            List<VideoGame> videoGames = new List<VideoGame>(ReadVideoGamesFromFile(path));
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
                        PrintAll(videoGames);
                        break;
                    case (int)Input.PrintPC: //Command 2
                        PrintPC(videoGames);
                        break;
                    case (int)Input.PrintConsole: //Command 3
                        PrintConsole(videoGames);
                        break;
                    case (int)Input.PrintHandheld: //Command 4
                        PrintHandheld(videoGames);
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