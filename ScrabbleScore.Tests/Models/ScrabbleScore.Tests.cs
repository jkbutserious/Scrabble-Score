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
    public void ArraySplit_SplitTheWordIntoAnArrayOfLetters_Array()
    {
      Words newWord = new Words("test");
      string[] Letters = newWord.ArraySplit();
      string[] Answer = { "w", "o", "r", "d" };
      Assert.AreEqual(Answer, Letters);
    }
    // [TestMethod]
    // public void RefrenceScore_RefrenceTheScoreForLetters_True()
    // {
      
    // }
  }
}