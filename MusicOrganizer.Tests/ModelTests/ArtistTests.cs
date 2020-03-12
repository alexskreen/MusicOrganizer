using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class ArtistTest 
  {

    // public void Dispose()
    // {
    //   Artist.ClearAll();
    // }
    [TestMethod]
    public void ArtistConstructor_CreatsInstanceOfArtist_Artist()
    {
      Artist newArtist = new Artist("test artist");
      Assert.AreEqual(typeof(Artist), newArtist.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Name";
      Artist newArtist = new Artist(name);

      //Act
      string result = newArtist.Name;

      //Assert
      Assert.AreEqual(name, result);
    }
  }
}