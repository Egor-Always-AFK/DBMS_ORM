using Microsoft.AspNetCore.Mvc.Formatters;
using MusicShop.config;
using MusicShop.repository.interfaces;
using MediaType = MusicShop.model.dictionary.MediaType;

namespace MusicShop.repository;

public class MediaRepository(ApplicationDbContext context) : IMediaRepository
{
    private ApplicationDbContext _context = context;

    public MediaType? getMediaTypeByName(string name)
    {
        return _context.MediaTypes.FirstOrDefault(mt => mt.name == name, null);
    }
}