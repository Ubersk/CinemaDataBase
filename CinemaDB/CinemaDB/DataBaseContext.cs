using CinemaDB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDB
{
    class DatabaseContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Composer> Composers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet <Session> Sessions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-FK64GM7\SQLEXPRESS;Database=CinemaDataBase;Trusted_Connection=True");
        }
    }
}
