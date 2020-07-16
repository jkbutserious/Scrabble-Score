using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleScoreTests : IDisposable
  {
    public void Dispose()
    {
      ScrabbleScore.ClearAll();
    }
    [TestMethod]
    public void WordConstructor_WillCreateAnInstanceOfWordObject_Word()
    {
      //Arrange
      Words newWord = new Words("test");
      Assert.AreEqual(typeof(Item), newWord.GetType());
    }
    [TestMethod]
    public void RefrenceScore_RefrenceTheScoreForLetters_True()
    {
      
    }
  }
}