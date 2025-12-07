namespace MusicShuffleMachine;

internal static class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter desired playlist length (minutes):");
        int minutes = int.Parse(Console.ReadLine());
        Console.WriteLine($"\nCustom Playlist ({minutes} minutes)\n");

        var result = GetCustomPlaylistByDesiredLength(minutes);
        foreach (var song in result.Playlist)
        {
            Console.WriteLine($"{song.Name} - {song.LengthInSeconds / 60}:{song.LengthInSeconds % 60:D2}");
        }
        Console.WriteLine($"\nTotal playlist time: {result.TotalTime}");
        Console.WriteLine("\nGrouped Songs");

        var groups = GroupSongsByFirstLetter();
        foreach (var g in groups)
        {
            Console.WriteLine($"{g.Key}: {string.Join(", ", g.Value)}");
        }
    }

    public static List<(string Name, int LengthInSeconds)> songs = new List<(string Name, int LengthInSeconds)>
    {
    ("Numb", ConvertToSeconds("3:07")),
    ("In The End", ConvertToSeconds("3:36")),
    ("Faint", ConvertToSeconds("2:42")),
    ("Breaking The Habit", ConvertToSeconds("3:16")),
    ("Somewhere I Belong", ConvertToSeconds("3:33")),
    ("Crawling", ConvertToSeconds("3:29")),
    ("One Step Closer", ConvertToSeconds("2:37")),
    ("Papercut", ConvertToSeconds("3:06")),
    ("Bleed It Out", ConvertToSeconds("2:44")),
    ("Burn It Down", ConvertToSeconds("3:51")),
    ("What I've Done", ConvertToSeconds("3:25")),
    ("New Divide", ConvertToSeconds("4:28")),
    ("Lost In The Echo", ConvertToSeconds("3:25")),
    ("A Place For My Head", ConvertToSeconds("3:05")),
    ("From The Inside", ConvertToSeconds("2:55")),
    ("Shadow Of The Day", ConvertToSeconds("4:49")),
    ("Given Up", ConvertToSeconds("3:09")),
    ("Lying From You", ConvertToSeconds("2:55"))
    };

    public static int ConvertToSeconds(string lenght)
    {
        var parts = lenght.Split(':');
        int minutes = int.Parse(parts[0]);
        int seconds = int.Parse(parts[1]);
        return minutes * 60 + seconds;
    }

    public static void ShuffleSongs() // Fisher-Yates shuffle algorithm
    {
        Random random = new Random();

        for (int i = songs.Count - 1; i > 0; i--)
        {
            int j = random.Next(0, i + 1);
            (songs[i], songs[j]) = (songs[j], songs[i]);
        }
    }

    public static (List<(string Name, int LengthInSeconds)> Playlist, string TotalTime)
    GetCustomPlaylistByDesiredLength(int lengthInMinutes)
    {
        int targetSeconds = lengthInMinutes * 60;
        List<(string Name, int LengthInSeconds)> playlist = new();
        int total = 0;

        ShuffleSongs();

        foreach (var song in songs)
        {
            if (total + song.LengthInSeconds <= targetSeconds)
            {
                playlist.Add(song);
                total += song.LengthInSeconds;
            }

            if (total >= targetSeconds)
                break;
        }

        int minutes = total / 60;
        int seconds = total % 60;
        string totalTime = $"{minutes:D2}:{seconds:D2}";

        return (playlist, totalTime);
    }
    public static Dictionary<char, List<string>> GroupSongsByFirstLetter()
    {
        Dictionary<char, List<string>> groups = new Dictionary<char, List<string>>();

        foreach (var song in songs)
        {
            char firstLetter = song.Name[0];

            if (!groups.ContainsKey(firstLetter))
            {
                groups[firstLetter] = new List<string>();
            }

            groups[firstLetter].Add(song.Name);
        }

        return groups;
    }

}





