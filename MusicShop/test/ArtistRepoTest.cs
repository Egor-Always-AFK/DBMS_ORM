using Microsoft.EntityFrameworkCore;
using MusicShop.config;
using MusicShop.model;
using MusicShop.repository;
using NUnit.Framework;

namespace MusicShop.test;

[TestFixture]
public class ArtistRepoTest
{
    private DbContextOptions<ApplicationDbContext> _options; 
    private ApplicationDbContext _context; 
    private ArtistRepository _repository;

    [SetUp]
    public void Setup()
    {
        _options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;
        _context = new ApplicationDbContext(_options);
        _repository = new ArtistRepository(_context);
    }

    [TearDown]
    public void Teardown()
    {
        _context.Database.EnsureDeleted();
        _context.Dispose();
    }

    [Test]
    public void AddArtist_ShouldAddArtist_WhenArtistDoesNotExist()
    {
        var artist = new Artists ( "Test Artist", "Test Bio");

        _repository.addArtist(artist);

        var result = _context.Artists.FirstOrDefault(a => a.name == "Test Artist");
        Assert.That(result, Is.Not.Null);
        Assert.That(result.name, Is.EqualTo("Test Artist"));
    }

    [Test]
    public void AddArtist_ShouldNotAddDuplicateArtist()
    {
        var artist = new Artists ("Test Artist","Test Bio");
        _context.Artists.Add(artist);
        _context.SaveChanges();

        _repository.addArtist(artist);

        var count = _context.Artists.Count(a => a.name == "Test Artist");
        Assert.That(count, Is.EqualTo(1));
    }

    [Test]
    public void GetArtistByName_ShouldReturnArtist_WhenArtistExists()
    {
        var artist = new Artists ("Test Artist", "Test Bio");
        _context.Artists.Add(artist);
        _context.SaveChanges();

        var result = _repository.getArtistByName("Test Artist");

        Assert.That(result, Is.Not.Null);
        Assert.That(result.name, Is.EqualTo("Test Artist"));
    }

    [Test]
    public void GetArtistByName_ShouldReturnNull_WhenArtistDoesNotExist()
    {
        var result = _repository.getArtistByName("Nonexistent Artist");
        Assert.That(result, Is.Null);
    }

    [Test]
    public void UpdateArtist_ShouldUpdateArtistDetails()
    {
        var artist = new Artists (1,  "Test Artist", "Old Bio");
        _context.Artists.Add(artist);
        _context.SaveChanges();

        artist.bio = "Updated Bio";
        _repository.updateArtist(artist);

        var updatedArtist = _context.Artists.FirstOrDefault(a => a.id == 1);
        Assert.That(updatedArtist.bio, Is.EqualTo("Updated Bio"));
    }

    [Test]
    public void DeleteArtist_ShouldRemoveArtist() 
    {
        var artist = new Artists(1, "Test Artist", "Test Bio");
        _context.Artists.Add(artist);
        _context.SaveChanges();

        _repository.deleteArtist(artist);

        var result = _context.Artists.FirstOrDefault(a => a.id == 1); 
        Assert.That(result, Is.Null);
    }
}