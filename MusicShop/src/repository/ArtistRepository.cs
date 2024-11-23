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
        _context.Artists.Add(artist);
        _context.SaveChanges();
    }

    public void updateArtist(Artists artists)
    {
        throw new NotImplementedException();
    }

    public void deleteArtist(long id)
    {
        throw new NotImplementedException();
    }
}