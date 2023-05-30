using ADO.NET_PW_5.Models;
using Microsoft.EntityFrameworkCore;

namespace ADO.NET_PW_5.Data {
    public class GameDbContext : DbContext {
        public DbSet<Game>? Games { get; set; }

        public DbSet<Studio>? Studio { get; set; }

        public DbSet<Style>? Style { get; set; }
        
        public DbSet<GameMode>? GameMode { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(
                "Server=127.0.0.1,1433;Database=Games;User Id=Server;Password=qwe123;TrustServerCertificate=True");
        }
    }
}