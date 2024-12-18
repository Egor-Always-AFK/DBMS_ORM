using MusicShop.model;

namespace MusicShop.repository;

public interface IAlbumRepository
{
    Album getAlbumtById(int id);

    Album getAlbumByName(string name);
    
    string? getAllAlbums();
    
    void addAlbums(Album? album);
    
    void updateAlbum(Album album);
    
    void deleteAlbum(Album album);
    
}