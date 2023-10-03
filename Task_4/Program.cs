internal class Program
{
    private static void Main(string[] args){
        int numberSong = int.Parse(Console.ReadLine());
        List<Song> song = new List<Song>();
        int SongAdded = 0;

        for (int i = 0; i < numberSong; i++)
        {
            try
            {
                string[] songInfo = Console.ReadLine().Split(';');
                string artistName = songInfo[0];
                string songName = songInfo[1];
                string[] songLength = songInfo[2].Split(':');
                if (songLength.Length != 2)
                {
                    throw new InvalidSongLengthException();
                }
                int minutes = int.Parse(songLength[0]);
                int seconds = int.Parse(songLength[1]);
                Song songs = new Song(artistName, songName, minutes, seconds);
                song.Add(songs);
                Console.WriteLine("Song added.");
                SongAdded++;

            }
            catch (InvalidSongException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        int totalHour = 0;
        int totalMinutes = 0;
        int totalSeconds = 0;

        for(int i = 0; i < song.Count; i++)
        {
            totalMinutes += song[i].Minutes;
            totalSeconds += song[i].Seconds;
        }
        totalMinutes += totalSeconds / 60;
        totalHour = totalMinutes / 60;
        totalSeconds %= 60; //ділимо націло на 60 це знаходимо скільки секунд залишилося 
        Console.WriteLine($"\nSongs added: {SongAdded}" +
            $"\nPlaylist length: {totalHour}h {totalMinutes}m {totalSeconds}s");
    }    
}