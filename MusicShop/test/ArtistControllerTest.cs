using System.Net;
using Microsoft.AspNetCore.Mvc;
using Moq;
using MusicShop.controller;
using MusicShop.dto;
using MusicShop.model;
using MusicShop.repository;
using NUnit.Framework;

namespace MusicShop.test;

[TestFixture]
public class ArtistControllerTest
{
    private Mock<IArtistsRepository> _mockRepo ;
    private ArtistController _artistController;
    
    [SetUp]
    public void setUp()
    {
        _mockRepo = new Mock<IArtistsRepository>();
        _artistController = new ArtistController(_mockRepo.Object);
    }
    
    [Test]
    public void AddArtist_ShouldReturnBadRequest_WhenArtistIsNull()
    { 
        ArtistDto? artist = null;
        
        var result = _artistController.AddArtist(artist);
    
       Assert.That(result.GetType(), Is.EqualTo(typeof(BadRequestObjectResult)));
       var badRequestResult = result as BadRequestObjectResult;
       Assert.That(badRequestResult?.Value, Is.EqualTo("Request body is empty"));
    }
    
    [Test] 
    public void AddArtist_ShouldReturnOk_WhenArtistIsAdded()
    { 
        var artistDto = new ArtistDto { name = "Artist", bio = "Bio of artist" };
           
        var result = _artistController.AddArtist(artistDto);
           
        Assert.That(result.GetType(), Is.EqualTo(typeof(OkObjectResult)));
        var okResult = result as OkObjectResult;
        Assert.That(okResult?.Value, Is.EqualTo("Success"));
    }
    
    [Test]
    public void SearchArtistByName_ShouldReturnNotFound_WhenArtistNotFound()
    {
        var artistName = "NonExistentArtist";
        _mockRepo.Setup(repo => repo.getArtistByName(artistName)).Returns((Artists)null);
    
        var result = _artistController.SearchArtistByName(artistName);
    
        Assert.That(result.GetType(), Is.EqualTo(typeof(NotFoundObjectResult)));
        var notFoundResult = result as NotFoundObjectResult;
        Assert.That(notFoundResult?.Value, Is.EqualTo("No Artist Found"));
    }
    
    [Test]
    public void SearchArtistByName_ShouldReturnOk_WhenArtistFound()
    {
        var artistName = "ExistingArtist";
        var artist = new Artists("ExistingArtist", "Bio of artist");
        _mockRepo.Setup(repo => repo.getArtistByName(artistName)).Returns(artist);
    
        var result = _artistController.SearchArtistByName(artistName);
        
        Assert.That(result.GetType(), Is.EqualTo(typeof(OkObjectResult)));
        var okResult = result as OkObjectResult;
        Assert.That(okResult?.Value, Is.EqualTo("Name: ExistingArtist\nBio: Bio of artist"));
    }

    [Test]
    public void UpdateBioByName_ShouldReturnNotFound_WhenArtistNotFound()
    {
        var artistDto = new ArtistDto { name = "NonExistentArtist", bio = "New Bio" };
        _mockRepo.Setup(repo => repo.getArtistByName(artistDto.name)).Returns((Artists)null);
    
        var result = _artistController.UpdateBioByName(artistDto);
    
        Assert.That(result.GetType(), Is.EqualTo(typeof(NotFoundObjectResult)));
        var notFoundResult = result as NotFoundObjectResult;
        Assert.That(notFoundResult?.Value, Is.EqualTo("No artist found"));
    }
    
    [Test]
    public void UpdateBioByName_ShouldReturnOk_WhenArtistUpdated()
    {
        var artistDto = new ArtistDto { name = "ExistingArtist", bio = "Updated Bio" };
        var artist = new Artists("ExistingArtist", "Old Bio");
        _mockRepo.Setup(repo => repo.getArtistByName(artistDto.name)).Returns(artist);
    
        var result = _artistController.UpdateBioByName(artistDto);
    
        Assert.That(result.GetType(), Is.EqualTo(typeof(OkObjectResult)));
        var okResult = result as OkObjectResult;
        Assert.That(okResult?.Value, Is.EqualTo("Artist updated"));
    }
    
    [Test]
    public void DeleteArtistByName_ShouldReturnNotFound_WhenArtistNotFound()
    {
        var artistName = "NonExistentArtist";
        _mockRepo.Setup(repo => repo.getArtistByName(artistName)).Returns((Artists)null);
    
        var result = _artistController.DeleteArtistByName(artistName);
    
        Assert.That(result.GetType(), Is.EqualTo(typeof(NotFoundObjectResult)));
        var notFoundResult = result as NotFoundObjectResult;
        Assert.That(notFoundResult?.Value, Is.EqualTo("No Artist found"));
    }
    
    [Test]
    public void DeleteArtistByName_ShouldReturnOk_WhenArtistDeleted()
    {
        var artistName = "ExistingArtist";
        var artist = new Artists("ExistingArtist", "Bio");
        _mockRepo.Setup(repo => repo.getArtistByName(artistName)).Returns(artist);
    
        var result = _artistController.DeleteArtistByName(artistName);
    
        Assert.That(result.GetType(), Is.EqualTo(typeof(OkObjectResult)));
        var okResult = result as OkObjectResult;
        Assert.That(okResult?.Value, Is.EqualTo("Artist deleted"));
    }
}