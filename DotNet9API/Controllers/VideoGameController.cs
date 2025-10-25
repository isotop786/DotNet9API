using DotNet9API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DotNet9API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController (VideoGameDbContext context) : ControllerBase
    {

        private readonly VideoGameDbContext _context = context;


        // get method
        [HttpGet]
        public async Task<ActionResult<List<VideoGame>>> GetVideoGames()
        {
            var games = await _context.VideoGames.ToListAsync();

            return Ok(games);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<VideoGame>> GetVideoGamebyId(int id)
        {
            var game = await _context.VideoGames.FindAsync(id);

            return game;
        }

        [HttpPost]
        public async Task<ActionResult<VideoGame>> AddVideoGame(VideoGame newGame)
        {
            if (newGame is null)
                return BadRequest();

            _context.VideoGames.Add(newGame);

            await _context.SaveChangesAsync();

          
            return CreatedAtAction(nameof(GetVideoGamebyId), new { id = newGame.Id }, newGame);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatedVideoGame(int id, VideoGame updatedGame)
        {
            var game = await _context.VideoGames.FindAsync(id);
            if (game is null)
                return NotFound();

            game.Title = updatedGame.Title;
            game.Platform = updatedGame.Platform;
            game.Publisher = updatedGame.Publisher;
            game.Developer = updatedGame.Developer;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task <IActionResult> DeleteVideoGame(int id)
        {
            var game = await _context.VideoGames.FindAsync(id);
            if (game is null)
                return NotFound();

            _context.VideoGames.Remove(game);

            await _context.SaveChangesAsync();
           
            return NoContent();

        }

    }
}
