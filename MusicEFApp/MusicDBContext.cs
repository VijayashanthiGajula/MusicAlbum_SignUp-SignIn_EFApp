using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicEFApp
{

    public class MusicDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog= Music ;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
               new User { UserId = 1, Name = "VJ", EmailId = "Admin@gmail.com", Password = "Admin@123", Role = "Admin" },
                new User { UserId = 2, Name = "user", EmailId = "user@gmail.com", Password = "user@123", Role = "User" });

            modelBuilder.Entity<Album>().HasData(
                new Album { AlbumId = 1, Name = "StarTrek" },
                new Album { AlbumId = 2, Name = "Medows" },
                new Album { AlbumId = 3, Name = "Peaches" },
                new Album { AlbumId = 4, Name = "Shallows" });

            modelBuilder.Entity<Song>().HasData(
                new Song { SongId = 1, AlbumId = 1, Title = "hello all" },
                 new Song { SongId = 2, AlbumId = 1, Title = "Neither I" },
                  new Song { SongId = 3, AlbumId = 1, Title = "Let it go" },
                   new Song { SongId = 4, AlbumId = 2, Title = "song 1" },
                    new Song { SongId = 5, AlbumId = 2, Title = "song 2" },
                    new Song { SongId = 6, AlbumId = 2, Title = "song 3" });
           

        }

    }

}