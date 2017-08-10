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
    public void TranslateNumber_TranslatesZeroToTen_True()
    {
      //Arrange
      NumberTranslator testNumber = new NumberTranslator(7);
      string expected = "seven";

      //Act
      string actual = testNumber.TranslateNumber();

      //Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TranslateNumber_TranslatesElevenToNineteen_True()
    {
      //Arrange
      NumberTranslator testNumber = new NumberTranslator(15);
      string expected = "fifteen";

      //Act
      string actual = testNumber.TranslateNumber();

      //Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TranslateNumber_TranslatesTwentyOneToNinetyNine_True()
    {
      //Arrange
      NumberTranslator testNumber = new NumberTranslator(33);
      string expected = "thirty-three";

      //Act
      string actual = testNumber.TranslateNumber();

      //Assert
      Assert.AreEqual(expected, actual);
    }

  }
}
