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
      NumberTranslator newTranslator = new NumberTranslator();
      Assert.AreEqual(typeof(NumberTranslator), newTranslator.GetType());
    }
  }
}