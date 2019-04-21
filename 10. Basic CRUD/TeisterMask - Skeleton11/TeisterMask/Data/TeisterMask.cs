using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using TeisterMask.Models;

namespace TeisterMask.Data
{
    public class TeisterMaskDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-OK0RAUD\SQLEXPRESS;Database=TeisterMaskDbContext;Trusted_Connection=true;");
        }
    }
}