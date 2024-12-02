using Microsoft.AspNetCore.Mvc;
using MusicShop.dto;
using MusicShop.model;
using MusicShop.repository;

namespace MusicShop.controller;

[ApiController]
[Route("/api/artist")]
public class ArtistController : ControllerBase
{
    
    private readonly IArtistsRepository _artistsRepository;

    public ArtistController(IArtistsRepository artistsRepository)
    {
        _artistsRepository = artistsRepository;
    }
    
    [HttpPost("addArtist")]
    public IActionResult AddArtist([FromBody] ArtistDto? artist)
    {
        if (artist == null) 
        {
            return BadRequest("Request body is empty");
        }
        _artistsRepository.addArtist(new Artists(artist.name, artist.bio));
        return Ok("Success");
    }

    [HttpGet("{name}")]
    public IActionResult SearchArtistByName(string name)
    {
        var found = _artistsRepository.getArtistByName(name);
        if (found == null)
        {
            return NotFound("No Artist Found");
        }
        return Ok("Name: " + found.name + "\nBio: " + found.bio);
    }

    [HttpPost("updateArtist")]
    public IActionResult UpdateBioByName([FromBody] ArtistDto? artist)
    {
        var found = _artistsRepository.getArtistByName(artist.name);
        Console.WriteLine(artist.name);
        if (found == null)
        {
            return NotFound("No artist found");
        }
        found.bio = artist.bio;
        _artistsRepository.updateArtist(found);
        return Ok("Artist updated");
    }

    [HttpDelete("deleteArtist/{name}")]
    public IActionResult DeleteArtistByName(string name)
    {
        var found = _artistsRepository.getArtistByName(name);
        if (found == null)
        {
            return NotFound("No Artist found");
        }
        _artistsRepository.deleteArtist(found);
        return Ok("Artist deleted");
    }
    
}