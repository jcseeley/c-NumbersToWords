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
    public string GetWrittenWords(int inputNum)
    {
      return "false";
    }
  }
}
