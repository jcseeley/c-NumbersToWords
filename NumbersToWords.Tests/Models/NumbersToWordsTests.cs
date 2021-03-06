using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;
using System;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class NumberTranslatorTests
  {
    [TestMethod]
    public void NumberTranslatorConstructor_CreateNumberTranslator_NumberTranslator()
    {
      NumberTranslator newTranslator = new NumberTranslator(1);
      Assert.AreEqual(typeof(NumberTranslator), newTranslator.GetType());
    }
    
    [TestMethod]
    public void NumberTranslator_AddNumberToConvert_NumberToConvert()
    {
      int numberToConvert = 5;
      NumberTranslator newTranslator = new NumberTranslator(numberToConvert);
      int result = newTranslator.NumberToConvert;
      Assert.AreEqual(numberToConvert, result);
    }
    
    [TestMethod]
        public void GetWrittenWords_ConvertNumberToWord_String()
    {
      int numberToConvert = 5;
      NumberTranslator newTranslator = new NumberTranslator(numberToConvert);
      string result = newTranslator.GetWrittenWords(numberToConvert);
      Assert.AreEqual("five", result);
    }

    [TestMethod]
        public void GetWrittenWords_ConvertDoubleDigitNumberToWord_String()
    {
      int numberToConvert = 99;
      NumberTranslator newTranslator = new NumberTranslator(numberToConvert);
      string result = newTranslator.GetWrittenWords(numberToConvert);
      Assert.AreEqual("ninetynine", result);
    }

    [TestMethod]
        public void GetWrittenWords_ConvertThreeDigitNumberToWord_String()
    {
      int numberToConvert = 222;
      NumberTranslator newTranslator = new NumberTranslator(numberToConvert);
      string result = newTranslator.GetWrittenWords(numberToConvert);
      Assert.AreEqual("twohundredtwentytwo", result);
    }
  }
}