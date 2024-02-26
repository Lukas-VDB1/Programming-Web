using WebApplication3.Models;

namespace WebApplication3.Data
{
    public interface IAnonymousEurosongDataContext
    {
        void AddSong(Song song);
        IEnumerable<Song> GetSongs();
    }
}
