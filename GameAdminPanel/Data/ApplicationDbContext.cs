using Microsoft.EntityFrameworkCore;
using GameAdminPanel.Models;

namespace GameAdminPanel.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    Id = 1,
                    Title = "The Witcher 3: Wild Hunt",
                    Description = "Эпическая RPG в открытом мире с захватывающим сюжетом",
                    ReleaseDate = new DateTime(2015, 5, 19)
                },
                new Game
                {
                    Id = 2,
                    Title = "Cyberpunk 2077",
                    Description = "RPG в мире будущего с элементами киберпанка",
                    ReleaseDate = new DateTime(2020, 12, 10)
                },
                new Game
                {
                    Id = 3,
                    Title = "Elden Ring",
                    Description = "Сложная action-RPG от создателей Dark Souls",
                    ReleaseDate = new DateTime(2022, 2, 25)
                }
            );
        }
    }
}