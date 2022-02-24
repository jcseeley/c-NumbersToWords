using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class NumberTranslator
  {
    public int NumberToConvert { get; set; }
    public NumberTranslator(int numberToConvert)
    {
      NumberToConvert = numberToConvert;
    }
    public string GetWrittenWords(int NumberToConvert)
    {
      string result = "";
      Dictionary<int, string> singleDigits = new Dictionary<int, string>() {
      {9,"nine"},
      {8,"eight"},
      {7,"seven"},
      {6,"six"},
      {5,"five"},
      {4,"four"},
      {3,"three"},
      {2,"two"},
      {1,"one"},
      {0, "zero"}
      };
      
      if (NumberToConvert <= 9)
      {
        result = singleDigits[NumberToConvert];
      }
      return result;
    }
  }
}
