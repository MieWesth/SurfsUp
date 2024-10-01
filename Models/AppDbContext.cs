using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace SurfsUp.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Board> Boards { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Wetsuit> Wetsuits { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Boards
            modelBuilder.Entity<Board>().HasData(
            new Board
            {
                BoardId = 1,
                Name = "The Minilog",
                Length = 6,
                Width = 21,
                Thickness = 2.75,
                Volume = 38.8,
                Type = "Shortboard",
                Price = 565,
                Equipment = "",
                ImagePath = "/images/surfboards/surfboard-1.jpg"
            },
            new Board
            {
                BoardId = 2,
                Name = "The Wide Glider",
                Length = 7.1,
                Width = 21.75,
                Thickness = 2.75,
                Volume = 44.16,
                Type = "Funboard",
                Price = 685,
                Equipment = "",
                ImagePath = "/images/surfboards/surfboard-2.jpg"
            },
            new Board
            {
                BoardId = 3,
                Name = "The Golden Ratio",
                Length = 6.3,
                Width = 21.85,
                Thickness = 2.9,
                Volume = 43.22,
                Type = "Funboard",
                Price = 695,
                Equipment = "",
                ImagePath = "/images/surfboards/surfboard-3.jpg"
            },
            new Board
            {
                BoardId = 4,
                Name = "Mahi Mahi",
                Length = 5.4,
                Width = 20.75,
                Thickness = 2.3,
                Volume = 29.39,
                Type = "Fish",
                Price = 645,
                Equipment = "",
                ImagePath = "/images/surfboards/surfboard-4.jpg"
            },
            new Board
            {
                BoardId = 5,
                Name = "The Emerald Glider",
                Length = 9.2,
                Width = 22.8,
                Thickness = 2.8,
                Volume = 65.4,
                Type = "Longboard",
                Price = 895,
                Equipment = "",
                ImagePath = "/images/surfboards/surfboard-5.jpg"
            },
            new Board
            {
                BoardId = 6,
                Name = "The Bomb",
                Length = 5.5,
                Width = 21,
                Thickness = 2.5,
                Volume = 33.7,
                Type = "Shortboard",
                Price = 645,
                Equipment = "",
                ImagePath = "/images/surfboards/surfboard-6.jpg"
            },
            new Board
            {
                BoardId = 7,
                Name = "Walden Magic",
                Length = 9.6,
                Width = 19.4,
                Thickness = 3,
                Volume = 80,
                Type = "Longboard",
                Price = 1025,
                Equipment = "",
                ImagePath = "/images/surfboards/surfboard-7.jpg"
            },
            new Board
            {
                BoardId = 8,
                Name = "Naish One",
                Length = 12.6,
                Width = 30,
                Thickness = 6,
                Volume = 301,
                Type = "SUP",
                Price = 854,
                Equipment = "Paddle",
                ImagePath = "/images/surfboards/surfboard-8.jpg"
            },
            new Board
            {
                BoardId = 9,
                Name = "Six Tourer",
                Length = 11.6,
                Width = 32,
                Thickness = 6,
                Volume = 270,
                Type = "SUP",
                Price = 611,
                Equipment = "Fin, Paddle, Pump, Leash",
                ImagePath = "/images/surfboards/surfboard-9.jpg"
            },
            new Board
            {
                BoardId = 10,
                Name = "Naish Maliko",
                Length = 14,
                Width = 25,
                Thickness = 6,
                Volume = 330,
                Type = "SUP",
                Price = 1304,
                Equipment = "Fin, Paddle, Pump, Leash",
                ImagePath = "/images/surfboards/surfboard-10.jpg"
            }
        );

            modelBuilder.Entity<Wetsuit>().HasData(
                new Wetsuit
                {
                    WetsuitId = 1,
                    Name = "Furnace Natural",
                    Gender = "Male",
                    WetsuitSize = 0,
                    Thickness = 2,
                    Price = 565,
                    ImagePath = "/images/wetsuits/wetsuit-1.jpg"
                },
                new Wetsuit
                {
                    WetsuitId = 2,
                    Name = "",
                    Gender = "",
                    WetsuitSize = 0,
                    Thickness = 2.75,
                    Price = 565,
                    ImagePath = "/images/wetsuits/wetsuit-1.jpg"
                },
                new Wetsuit
                {
                    WetsuitId = 3,
                    Name = "",
                    Gender = "",
                    WetsuitSize = 0,
                    Thickness = 2.75,
                    Price = 565,
                    ImagePath = "/images/wetsuits/wetsuit-1.jpg"
                },
                new Wetsuit
                {
                    WetsuitId = 4,
                    Name = "",
                    Gender = "",
                    WetsuitSize = 0,
                    Thickness = 2.75,
                    Price = 565,
                    ImagePath = "/images/wetsuits/wetsuit-1.jpg"
                },
                new Wetsuit
                {
                    WetsuitId = 5,
                    Name = "",
                    Gender = "",
                    WetsuitSize = 0,
                    Thickness = 2.75,
                    Price = 565,
                    ImagePath = "/images/wetsuits/wetsuit-1.jpg"
                });
        }
    }
}



