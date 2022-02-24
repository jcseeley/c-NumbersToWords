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
      {19,"nineteen"},
      {18,"eighteen"},
      {17,"seventeen"},
      {16,"sixteen"},
      {15,"fifteen"},
      {14,"fourteen"},
      {13,"thirteen"},
      {12,"twelve"},
      {11,"eleven"},
      {10,"ten"},
      {9,"nine"},
      {8,"eight"},
      {7,"seven"},
      {6,"six"},
      {5,"five"},
      {4,"four"},
      {3,"three"},
      {2,"two"},
      {1,"one"},
      {0,"zero"}
      };

      Dictionary<int, string> doubleDigits = new Dictionary<int, string>() {
      {2,"twenty"},
      {3,"thirty"},
      {4,"forty"},
      {5,"fifty"},
      {6,"sixty"},
      {7,"seventy"},
      {8,"eighty"},
      {9,"ninety"},
      };
    
        if (NumberToConvert <= 19)
        {
          result = singleDigits[NumberToConvert];
        }
        else if (NumberToConvert > 19)
        {
          string num = NumberToConvert.ToString();
          char[] numArr = num.ToCharArray();
          
          if(numArr.Length ==2)
          {
            if (numArr[1] == '0')
            {
              result = doubleDigits[int.Parse((numArr[0]).ToString())];
            }
            else
            {
              result = doubleDigits[int.Parse((numArr[0]).ToString())] + singleDigits[int.Parse((numArr[1]).ToString())];
            }
          }
          if(numArr.Length ==3)
          {
            String hundredDigit= GetWrittenWords(int.Parse((numArr[0]).ToString()));
            String tenDigit=  numArr[1].ToString()+numArr[2].ToString();
            String tenDigitWord= GetWrittenWords(int.Parse(tenDigit));
            result = hundredDigit + "hundred"+tenDigitWord;
          }
        }
      
      return result;
    }
  }
}
