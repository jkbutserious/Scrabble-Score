using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Scrabble.Models;


namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleScoreTests
  {
    [TestMethod]
    public void WordConstructor_WillCreateAnInstanceOfWordObject_Word()
    {
      //Arrange
      Words newWord = new Words("test");
      Assert.AreEqual(typeof(Words), newWord.GetType());
    }
    [TestMethod]
    public void RefrenceScore_RefrenceTheScoreForLetters_True()
    {
      
    }
  }
}