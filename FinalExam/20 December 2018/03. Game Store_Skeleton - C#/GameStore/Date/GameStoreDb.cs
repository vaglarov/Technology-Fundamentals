using GameStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameStore.Date
{
    public class GameStoreDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-OK0RAUD\SQLEXPRESS;Database=GameStoreDb;Trusted_Connection=true;");
        }
    }
}
