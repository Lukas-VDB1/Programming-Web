using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class AnonymousEurosongDataList : IAnonymousEurosongDataContext
    {
        List<Song> songs = new List<Song>();
        public void AddSong(Song song)
        {
            songs.Add(song);
        }
        public IEnumerable<Song> GetSongs()
        {
            return songs;
        }
    }
}
