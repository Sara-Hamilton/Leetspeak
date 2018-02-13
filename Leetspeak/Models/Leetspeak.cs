using System.Collections.Generic;
using System;

namespace Leetspeak.Models
{
  public class LeetspeakGenerator
  {
    public string Leetspeak(string inputString)
    {
      string translatedString = inputString.Replace('e','3').Replace('E','3').Replace('o','0').Replace('O','0').Replace('I','1').Replace('s','z').Replace('S','Z');
      if(inputString[0] == 's' || inputString[0] == 'S')
      {
        char[] chars = translatedString.ToCharArray();
        chars[0] = inputString[0];
        translatedString = new string(chars);
      }
      return translatedString;
    }
  }
}
