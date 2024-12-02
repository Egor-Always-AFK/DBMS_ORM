using Microsoft.EntityFrameworkCore;
using MusicShop.config;
using MusicShop.model;

namespace MusicShop.repository;

public class ArtistRepository : IArtistsRepository
{
    
    private readonly ApplicationDbContext _context;
    
    public ArtistRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public Artists? getArtistByName(string name)
    {
        return _context.Artists.FirstOrDefault(t => t.name.Equals(name));
    }

    public Artists? getArtistById(int id)
    {
        throw new NotImplementedException();
    }

    public string? getAllArtists()
    {
        throw new NotImplementedException();
    }

    public void addArtist(Artists? artist)
    {
        var artists = this.getArtistByName(artist.name);
        if (artists == null)
        {
            _context.Artists.Add(artist);
            _context.SaveChanges();
        }
    }

    public void updateArtist(Artists artists)
    {
        Console.WriteLine(artists.name + " | " + artists.bio);
        _context.Artists.Update(artists);  
        _context.SaveChanges();
    }

    public void deleteArtist(Artists artist)
    {
        _context.Artists.Remove(artist);    
        _context.SaveChanges();
    }
}