namespace COMPSCI221_Final_Project
{
    public class VideoGame
    {
        private string gameType;
        private string title;
        private string developer;
        private string publisher;
        private int releaseYear;
        private string genre;
        private string platform;
        private int averagePlaytime;
        private double rating;

        public VideoGame(string gameType, string title, string developer, string publisher, int releaseYear, string genre, string platform, int averagePlaytime, double rating)
        {
            GameType = gameType;
            Title = title;
            Developer = developer;
            Publisher = publisher;
            ReleaseYear = releaseYear;
            Genre = genre;
            Platform = platform;
            AveragePlaytime = averagePlaytime;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"Game Type: {GameType}\n" +
           $"Title: {Title}\n" +
           $"Developer: {Developer}\n" +
           $"Publisher: {Publisher}\n" +
           $"Release Year: {ReleaseYear}\n" +
           $"Genre: {Genre}\n" +
           $"Platform: {Platform}\n" +
           $"Average Playtime: {AveragePlaytime} hours\n" +
           $"Rating: {Rating}\n";
        }

        public string GameType
        {
            get => gameType;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new System.Exception("Game cannot be empty.");
                }
                gameType = value;
            }
        }

        public string Title
        {
            get => title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new System.Exception("Title cannot be empty.");
                }
                title = value;
            }
        }

        public string Developer
        {
            get => developer;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new System.Exception("Developer cannot be empty.");
                }
                developer = value;
            }
        }

        public string Publisher
        {
            get => publisher;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new System.Exception("Publisher cannot be empty.");
                }
                publisher = value;
            }
        }

        public int ReleaseYear
        {
            get => releaseYear;
            set
            {
                if (value < 1958 || value > 2026)
                {
                    throw new System.Exception("Release year must be 1958-2026.");
                }
                releaseYear = value;
            }
        }

        public string Genre
        {
            get => genre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new System.Exception("Genre cannot be empty.");
                }
                genre = value;
            }
        }

        public string Platform
        {
            get => platform;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new System.Exception("Platform cannot be empty.");
                }
                platform = value;
            }
        }

        public int AveragePlaytime
        {
            get => averagePlaytime;
            set
            {
                if (value < 0)
                {
                    throw new System.Exception("Average playtime must be positive.");
                }
                averagePlaytime = value;
            }
        }

        public double Rating
        {
            get => rating;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new System.Exception("Rating must at least be 0-100.");
                }
                rating = value;
            }
        }
    }
}