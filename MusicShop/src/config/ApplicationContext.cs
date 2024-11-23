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
        // Настройки для Album
        modelBuilder.Entity<Album>()
            .ToTable("albums")
            .HasKey(a => a.id);
        
        modelBuilder.Entity<Album>()
            .Property(a => a.title)
            .IsRequired();
        
        modelBuilder.Entity<Artists>()
            .ToTable("artists")
            .HasKey(a => a.id);

        modelBuilder.Entity<Artists>()
            .Property(a => a.name)
            .IsRequired(); 
        
        modelBuilder.Entity<Track>()
            .ToTable("tracks")
            .HasKey(t => t.id);

        modelBuilder.Entity<Track>()
            .Property(t => t.title)
            .IsRequired(); 

        modelBuilder.Entity<Track>()
            .Property(t => t.duration)
            .IsRequired(); 


        modelBuilder.Entity<Track>()
            .HasOne<Album>()
            .WithMany()
            .HasForeignKey(t => t.albumId);

        modelBuilder.Entity<Album>()
            .HasOne<Artists>()
            .WithMany()
            .HasForeignKey(a => a.id);
    }
}