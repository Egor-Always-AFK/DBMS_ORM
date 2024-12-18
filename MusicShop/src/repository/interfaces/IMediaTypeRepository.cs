using MediaType = MusicShop.model.dictionary.MediaType;

namespace MusicShop.repository.interfaces;

public interface IMediaRepository
{
    MediaType? getMediaTypeByName(string name);
}