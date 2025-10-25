using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet9API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        static private List<VideoGame> videoGames = new List<VideoGame>
        {
                new VideoGame
                {
                    Id = 1,
                    Title = "Spider-Man 2",
                    Platform = "PS5",
                    Developer = "Insomniac Games",
                    Publisher = "Sony Interactive Entertainment"
                },
                new VideoGame
                {
                    Id = 2,
                    Title = "The Legend of Zelda: Breath of the Wild",
                    Platform = "Nintendo Switch",
                    Developer = "Nintendo EPD",
                    Publisher = "Nintendo"
                },
                new VideoGame
                {
                    Id = 3,
                    Title = "God of War Ragnarök",
                    Platform = "PS5",
                    Developer = "Santa Monica Studio",
                    Publisher = "Sony Interactive Entertainment"
                },
                new VideoGame
                {
                    Id = 4,
                    Title = "Elden Ring",
                    Platform = "PS5",
                    Developer = "FromSoftware",
                    Publisher = "Bandai Namco Entertainment"
                },
                new VideoGame
                {
                    Id = 5,
                    Title = "Halo Infinite",
                    Platform = "Xbox Series X",
                    Developer = "343 Industries",
                    Publisher = "Xbox Game Studios"
                },
                new VideoGame
                {
                    Id = 6,
                    Title = "Starfield",
                    Platform = "PC",
                    Developer = "Bethesda Game Studios",
                    Publisher = "Bethesda Softworks"
                },
                new VideoGame
                {
                    Id = 7,
                    Title = "Super Mario Odyssey",
                    Platform = "Nintendo Switch",
                    Developer = "Nintendo EPD",
                    Publisher = "Nintendo"
                },
                new VideoGame
                {
                    Id = 8,
                    Title = "Cyberpunk 2077",
                    Platform = "PC",
                    Developer = "CD Projekt Red",
                    Publisher = "CD Projekt"
                },
                new VideoGame
                {
                    Id = 9,
                    Title = "Horizon Forbidden West",
                    Platform = "PS5",
                    Developer = "Guerrilla Games",
                    Publisher = "Sony Interactive Entertainment"
                },
                new VideoGame
                {
                    Id = 10,
                    Title = "Red Dead Redemption 2",
                    Platform = "PS5",
                    Developer = "Rockstar Games",
                    Publisher = "Rockstar Games"
                },

        };

        // get method
        [HttpGet]
        public ActionResult<List<VideoGame>> GetVideoGames()
        {
            return Ok(videoGames);
        }

        [HttpGet("{id}")]
        public ActionResult<VideoGame> GetVideoGamebyId(int id)
        {
            var game = videoGames.FirstOrDefault(x => x.Id == id);

            return game;
        }
    }
}
