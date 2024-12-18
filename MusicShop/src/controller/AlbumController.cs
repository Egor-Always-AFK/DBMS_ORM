using Microsoft.AspNetCore.Mvc;
using MusicShop.dto;
using MusicShop.model;
using MusicShop.repository;
using MusicShop.repository.interfaces;

namespace MusicShop.controller;

[ApiController]
[Route("/api/album")]
public class AlbumController(IArtistsRepository artistsRepo, IMediaRepository mediaTypeRepo, IAlbumRepository albumRepo) : ControllerBase
{
    
    private IArtistsRepository artistsRepo = artistsRepo;
    
    private IMediaRepository mediaTypeRepo = mediaTypeRepo;
    
    private IAlbumRepository albumRepo = albumRepo;


    [HttpPost("add")]
    public IActionResult addAlbum([FromBody] AlbumDto? albumDto)
    {
        if (albumDto == null)
        {
            return BadRequest("Request body is null");
        }
        Console.WriteLine(albumDto.mediaType);
        // asdasasasdasdsdwadasddasdasdf
        var foundMediaType = mediaTypeRepo.getMediaTypeByName(albumDto.mediaType);
        if (foundMediaType == null)
        {
            return BadRequest("Requested media type is not found");
        }

        var foundArtist = artistsRepo.getArtistByName(albumDto.artistName);
        if (foundArtist == null)
        {
            return BadRequest("Requested artist is not found");
        }
        
        albumRepo.addAlbums(new Album(foundArtist.id, foundMediaType.id, albumDto.title));
        return Ok("Album added");
    }   
}