using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SongsController : ControllerBase
    {
        private IAnonymousEurosongDataContext _data;
        public SongsController(IAnonymousEurosongDataContext data)
        {
            _data = data;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Song>> Get()
        {
            return Ok(_data.GetSongs());
        }
        [HttpPost]
        public ActionResult Post([FromBody] Song song)
        {
            _data.AddSong(song);
            return Ok("Hooray");
        }
    }
}
