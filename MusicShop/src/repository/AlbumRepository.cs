using MusicShop.config;
using MusicShop.model;

namespace MusicShop.repository;

public class AlbumRepository : IAlbumRepository
{
    
    private readonly ApplicationDbContext _context;
    
    public AlbumRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public Album getAlbumtById(int id)
    {
        return _context.Albums.Find(id);
    }

    public Album getAlbumByName(string name)
    {
        return _context.Albums.FirstOrDefault(a => a.title == name);
    }

    public string? getAllAlbums()
    {
        return _context.Albums.ToString();
    }

    public void addAlbums(Album? album)
    {
        var found = _context.Albums.FirstOrDefault(a => a.title == album.title);
        if ((found.artistId == album.artistId && found.mediaId != album.mediaId) && found == null)
        {
            _context.Albums.Add(album);
            _context.SaveChanges();   
        }
    }

    public void updateAlbum(Album album)
    {
        throw new NotImplementedException();
    }

    public void deleteAlbum(Album album)
    {
        throw new NotImplementedException();
    }
    
}