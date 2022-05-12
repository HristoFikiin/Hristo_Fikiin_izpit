using BussinesLayer;
using Microsoft.EntityFrameworkCore;
namespace DataLayer
{
    public class PlayersDBContext : DbContext
    {
        public PlayersDBContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=127.0.0.1;Port=3306;Database=playersdb;Uid=root;Pwd=123456;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}