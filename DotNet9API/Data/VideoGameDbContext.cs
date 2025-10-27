using DotNet9API.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet9API.Data
{
    public class VideoGameDbContext(DbContextOptions<VideoGameDbContext> options) : DbContext(options)
    {
        public DbSet<VideoGame> VideoGames { get; set; }
        public DbSet<VideoGameDetails> VideoGameDetails => Set<VideoGameDetails>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VideoGame>().HasData(

                 new VideoGame
                 {
                     Id = 1,
                     Title = "Spider-Man 2",
                     Platform = "PS5",
                    
                 },
                new VideoGame
                {
                    Id = 2,
                    Title = "The Legend of Zelda: Breath of the Wild",
                    Platform = "Nintendo Switch",
                    
                },
                new VideoGame
                {
                    Id = 3,
                    Title = "God of War Ragnarök",
                    Platform = "PS5",
                    
                },
                new VideoGame
                {
                    Id = 4,
                    Title = "Elden Ring",
                    Platform = "PS5",
                    
                },
                new VideoGame
                {
                    Id = 5,
                    Title = "Halo Infinite",
                    Platform = "Xbox Series X",
                },
                new VideoGame
                {
                    Id = 6,
                    Title = "Starfield",
                    Platform = "PC",
                },
                new VideoGame
                {
                    Id = 7,
                    Title = "Super Mario Odyssey",
                    Platform = "Nintendo Switch",
                },
                new VideoGame
                {
                    Id = 8,
                    Title = "Cyberpunk 2077",
                    Platform = "PC",
                },
                new VideoGame
                {
                    Id = 9,
                    Title = "Horizon Forbidden West",
                    Platform = "PS5",
                },
                new VideoGame
                {
                    Id = 10,
                    Title = "Red Dead Redemption 2",
                    Platform = "PS5",
                }


                );
        }
    }
}
