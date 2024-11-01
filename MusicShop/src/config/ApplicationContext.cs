using Microsoft.EntityFrameworkCore;
using MusicShop.model;
using MusicShop.model.dictionary;

namespace MusicShop.config;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Album> Albums { get; set; }
    public DbSet<Artists> Artists { get; set; }
    public DbSet<Track> Tracks { get; set; }
    public DbSet<Genres> Genres { get; set; }
    public DbSet<MediaType> MediaTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Дополнительные конфигурации при необходимости
    }
}