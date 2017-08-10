using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;
using System.Collections.Generic;
using System;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class NumbersToWordsTest
  {
    [TestMethod]
    public void TranslateNumber_TranslatesZeroToNine_True()
    {
      //Arrange
      NumberTranslator testNumber = new NumberTranslator(7);
      string expected = "seven";

      //Act
      string actual = testNumber.TranslateNumber();

      //Assert
      Assert.AreEqual(expected, actual);
    }

  }
}
