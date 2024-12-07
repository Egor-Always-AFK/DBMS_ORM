using MusicShop.model;

namespace MusicShop.repository;

public interface IAlbumRepository
{
    Album getAlbumtById(int id);

    Album getAlbumtByName(string name);
    
    string? getAllAlbums();
    
    void addAlbums(Album? album);
    
    void updateAlbum(Album album);
    
    void deleteAlbum(Album album);
    
    Album? getAlbumByName(string name);
}