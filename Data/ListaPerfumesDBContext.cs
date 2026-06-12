using Microsoft.EntityFrameworkCore;
using ListaPerfumes.Models;

namespace ListaPerfumes.Data
{
    public class ListaPerfumesDBContext : DbContext
    {
        public DbSet<Perfume> Perfumes => Set<Perfume>();
        public DbSet<Avaliacao> Avaliacoes => Set<Avaliacao>();
        public DbSet<ColecaoItem> ColecaoItems => Set<ColecaoItem>();
        public DbSet<Wishlist> WishlistItems => Set<Wishlist>();
        public DbSet<Contratipo> Contratipos => Set<Contratipo>();
    

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ListaPerfumes.db");
            Directory.CreateDirectory(Path.GetDirectoryName(dbPath)!);
            options.UseSqlite($"Data Source={dbPath}");
        }
    }
}
