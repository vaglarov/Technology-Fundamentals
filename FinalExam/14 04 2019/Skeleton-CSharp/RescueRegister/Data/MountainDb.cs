using Microsoft.EntityFrameworkCore;
using RescueRegister.Models;



namespace RescueRegister.Data
{
    public class MountainDb : DbContext
    {
       
        public DbSet<Mountaineer> Mountaineers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-OK0RAUD\SQLEXPRESS;Database=MountainDb;Trusted_Connection=true;");
        }
    }
}
