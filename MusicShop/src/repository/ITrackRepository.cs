using Microsoft.AspNetCore.Mvc;
using MusicShop.model;

namespace MusicShop.repository;

public interface ITrackRepository 
{
    Track? getTrackById(int id);
    
    string? getAllTracks();
    
    string? getAllTracksByGenre(string genre);

    public string? GetAllTracksByArtistName(string artistName);
    
    void addTrack(Track track);
    
    void updateTrack(Track track);
    
    void deleteTrack(Track track);
}