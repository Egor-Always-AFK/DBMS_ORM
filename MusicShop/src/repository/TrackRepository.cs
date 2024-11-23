using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MusicShop.config;
using MusicShop.model;

namespace MusicShop.repository;

public class TrackRepository : ITrackRepository
{
    private readonly ApplicationDbContext _context;

    public TrackRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public Track? getTrackById(int id)
    {
        return _context.Tracks.Find(id);
    }

    public string? getAllTracks()
    {
       return _context.Tracks.ToList().ToString();
    }

    public string? getAllTracksByGenre(string genre)
    {
        var foundGenre = _context.Genres.FirstOrDefault(g => g.name.Equals(genre));

        if (foundGenre == null)
        {
            return "notFound";
        }

        var tracks = _context.Tracks.Where(t => t.genreId == foundGenre.id).ToList();

        if (!tracks.Any())
        {
            return "noContent";
        }

        return tracks.ToString();
    }

    public string? GetAllTracksByArtistName(string artistName)
    {
        return _context.Tracks.Find(artistName)?.ToString();
    }

    public void addTrack(Track track)
    {
        throw new NotImplementedException();
    }

    public void updateTrack(Track track)
    {
        throw new NotImplementedException();
    }

    public void deleteTrack(Track track)
    {
        throw new NotImplementedException();
    }
}