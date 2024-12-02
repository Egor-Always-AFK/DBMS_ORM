﻿using MusicShop.model;

namespace MusicShop.repository;

public interface IArtistsRepository
{
    Artists? getArtistById(int id);
    
    string? getAllArtists();
    
    void addArtist(Artists? artists);
    
    void updateArtist(Artists artists);
    
    void deleteArtist(Artists artist);
    
    Artists? getArtistByName(string name);
}