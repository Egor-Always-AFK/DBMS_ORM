using Microsoft.AspNetCore.Mvc;
using MusicShop.dto;
using MusicShop.model;
using MusicShop.repository;

namespace MusicShop.controller;

[ApiController]
[Route("/api/track")]
public class TrackController : ControllerBase
{
    private readonly ITrackRepository _trackRepository;
    
    private readonly IAlbumRepository _albumRepository;
    
    public TrackController(ITrackRepository trackRepository, IAlbumRepository albumRepository)
    {
        _trackRepository = trackRepository;
        _albumRepository = albumRepository;
    }
    
    [HttpGet("hello")]
    public String hello() => "Hello world!";

    [HttpGet("name/{artistName}")]
    public string? SearchAllTracksByArtistName(String artistName)
    {
        System.Console.WriteLine($"Search all tracks by {artistName}");
        if (artistName.Equals("Toxi$"))
        {
            return
                "\nЕ-е-е, yeah\nYeah, yeah\nYeah, yeah\nYeah, yeah\n\nПочему ты с ним, а не со мной?\nМне больно, ведь сейчас с тобой тусуется другой\nЯ говорю ей: «Иди»\nМне нужен покой\nЯ снова вою под луной\nУ меня траблы с\u205fголовой,\u205fи\u205fты причина (DJ\u205fTape)\n\n\nДетка, да, я\u205fhurt, hurt, hurt, hurt, hurt\nRidin' in a 'Vette — это машина (У, у, у)\nI don't know what you heard, heard, heard, heard, heard\nЯ заливаю four — это туссина (У, у, у)\n\nЯ не знаю, что ты слышала (Фью)\nНо я могу сказать: это неправда (Йоу, йоу)\nЯ не могу любить этих шалав\nВедь я люблю только тебя — и это факты\n\nI can't love no hoes (Е, е, е)\nI can't love no hoes\nI can't love no hoes\nI can't love no hoes (Е, е, е)\nЯ словно Santa Claus\nВ пакете много sauce, а вокруг много hoes and snow\n\n\nДетка, да, я hurt, hurt, hurt, hurt, hurt\nRidin' in a 'Vette — это машина (У, у, у)\nI don't know what you heard, heard, heard, heard, heard\nЯ заливаю four — это туссина\nДетка, да, я hurt, hurt, hurt, hurt, hurt\nRidin' in a 'Vette — это машина (У, у, у)\nI don't know what you heard, heard, heard, heard, heard\nЯ заливаю four — это туссина (У, у, у)\n\nЯ говорю ей: «Иди»\nЯ говорю ей: «Иди»\nЯ говорю ей: «Иди»\nЯ говорю ей: «Иди»\nЯ говорю ей: «Иди»\nЯ говорю ей: «Иди»\nЯ говорю ей: «Иди»\nМне нужен покой…";
        }
        
        // return _repository.GetAllTracksByArtistName(artistName);?
        return "WIP";
    }

    [HttpGet("all")]
    public string? getAllTracks()
    {
        return _trackRepository.getAllTracks()?.ToString();
    }

    [HttpGet("genre/{genreName}")]
    public string? searchAllTracksByGenre(String genreName)
    {
        return _trackRepository.getAllTracksByGenre(genreName)?.ToString();
    }


}