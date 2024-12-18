using Microsoft.AspNetCore.Mvc;
using MusicShop.model;

namespace MusicShop.repository;

public interface ITrackRepository 
{
    Track? getTrackById(int id);
    
    string? getAllTracks();
    
    string? getAllTracksByGenre(string genre);

    Track? getTrackByName(string name);

    public string? GetAllTracksByArtistName(string artistName);
    
    void addTrack(Track track);
    
    void updateTrack(Track track);
    
    void deleteTrack(Track track);
}