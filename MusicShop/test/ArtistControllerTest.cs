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
    // private Mock<IArtistsRepository> _mockRepo ;
    // private ArtistController _artistController;
    //
    // [SetUp]
    // public void setUp()
    // {
    //     _mockRepo = new Mock<IArtistsRepository>();
    //     _artistController = new ArtistController(_mockRepo.Object);
    // }
    //
    //  [Test]
    //  public void AddArtist_ShouldReturnBadRequest_WhenArtistIsNull()
    //  { 
    //      ArtistDto? artist = null;
    //      
    //      var result = _artistController.AddArtist(artist);
    //
    //     Assert.Equals(result.GetType(), typeof(BadRequestResult));
    //     var badRequestResult = result as BadRequestObjectResult; 
    //     Assert.Equals("Request body is empty", badRequestResult?.Value);
    //  }
    //
    //  [Test] 
    //  public void AddArtist_ShouldReturnOk_WhenArtistIsAdded()
    //  { 
    //      var artistDto = new ArtistDto { name = "Artist", bio = "Bio of artist" };
    //         
    //      var result = _artistController.AddArtist(artistDto);
    //         
    //      Assert.Equals(result.GetType(), typeof(OkResult));
    //      var okResult = result as OkObjectResult;
    //      Assert.Equals("Success", okResult?.Value);
    //      _mockRepo.Verify(repo => repo.addArtist(It.IsAny<Artists>()), Times.Once);
    //  }
    //
    // [Test]
    // public void SearchArtistByName_ShouldReturnNotFound_WhenArtistNotFound()
    // {
    //     var artistName = "NonExistentArtist";
    //     _mockRepo.Setup(repo => repo.getArtistByName(artistName)).Returns((Artists)null);
    //
    //     var result = _artistController.SearchArtistByName(artistName);
    //
    //     Assert.Equals(result.GetType(), typeof(NotFoundResult));
    //     var notFoundResult = result as NotFoundObjectResult;
    //     Assert.Equals("No Artist Found", notFoundResult?.Value);
    // }
    //
    // [Test]
    // public void SearchArtistByName_ShouldReturnOk_WhenArtistFound()
    // {
    //     var artistName = "ExistingArtist";
    //     var artist = new Artists("ExistingArtist", "Bio of artist");
    //     _mockRepo.Setup(repo => repo.getArtistByName(artistName)).Returns(artist);
    //
    //     var result = _artistController.SearchArtistByName(artistName);
    //     
    //     Assert.Equals(result.GetType(), typeof(OkResult));
    //     var okResult = result as OkObjectResult;
    //     Assert.Equals("Name: ExistingArtist\nBio: Bio of artist", okResult?.Value);
    // }
    //
    // [Test]
    // public void UpdateBioByName_ShouldReturnNotFound_WhenArtistNotFound()
    // {
    //     var artistDto = new ArtistDto { name = "NonExistentArtist", bio = "New Bio" };
    //     _mockRepo.Setup(repo => repo.getArtistByName(artistDto.name)).Returns((Artists)null);
    //
    //     var result = _artistController.UpdateBioByName(artistDto);
    //
    //     Assert.Equals(result.GetType(), typeof(NotFoundResult));
    //     var notFoundResult = result as NotFoundObjectResult;
    //     Assert.Equals("No artist found", notFoundResult?.Value);
    // }
    //
    // [Test]
    // public void UpdateBioByName_ShouldReturnOk_WhenArtistUpdated()
    // {
    //     var artistDto = new ArtistDto { name = "ExistingArtist", bio = "Updated Bio" };
    //     var artist = new Artists("ExistingArtist", "Old Bio");
    //     _mockRepo.Setup(repo => repo.getArtistByName(artistDto.name)).Returns(artist);
    //
    //     var result = _artistController.UpdateBioByName(artistDto);
    //
    //     Assert.Equals(result.GetType(), typeof(OkResult));
    //     var okResult = result as OkObjectResult;
    //     Assert.Equals("Artist updated", okResult?.Value);
    //     _mockRepo.Verify(repo => repo.updateArtist(It.IsAny<Artists>()), Times.Once);
    // }
    //
    // [Test]
    // public void DeleteArtistByName_ShouldReturnNotFound_WhenArtistNotFound()
    // {
    //     var artistName = "NonExistentArtist";
    //     _mockRepo.Setup(repo => repo.getArtistByName(artistName)).Returns((Artists)null);
    //
    //     var result = _artistController.DeleteArtistByName(artistName);
    //
    //     Assert.Equals(result.GetType(), typeof(NotFoundResult));
    //     var notFoundResult = result as NotFoundObjectResult;
    //     Assert.Equals("No Artist found", notFoundResult?.Value);
    // }
    //
    // [Test]
    // public void DeleteArtistByName_ShouldReturnOk_WhenArtistDeleted()
    // {
    //     var artistName = "ExistingArtist";
    //     var artist = new Artists("ExistingArtist", "Bio");
    //     _mockRepo.Setup(repo => repo.getArtistByName(artistName)).Returns(artist);
    //
    //     var result = _artistController.DeleteArtistByName(artistName);
    //
    //     Assert.Equals(result.GetType(), typeof(OkResult));
    //     var okResult = result as OkObjectResult;
    //     Assert.Equals("Artist deleted", okResult?.Value);
    //     _mockRepo.Verify(repo => repo.deleteArtist(It.IsAny<Artists>()), Times.Once);
    // }
}