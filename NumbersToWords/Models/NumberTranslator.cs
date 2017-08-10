using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class NumberTranslator
  {
    private int _inputNumber;
    private string _returnWord;

    private Dictionary<int, string> translationGuide = new Dictionary<int, string> {};

    public void BuildDictionary()
    {
      translationGuide.Add(0, "zero");
      translationGuide.Add(1, "one");
      translationGuide.Add(2, "two");
      translationGuide.Add(3, "three");
      translationGuide.Add(4, "four");
      translationGuide.Add(5, "five");
      translationGuide.Add(6, "six");
      translationGuide.Add(7, "seven");
      translationGuide.Add(8, "eight");
      translationGuide.Add(9, "nine");
      translationGuide.Add(10, "ten");

      //11-20
      translationGuide.Add(11, "eleven");
      translationGuide.Add(12, "twelve");
      translationGuide.Add(13, "thirteen");
      translationGuide.Add(14, "fourteen");
      translationGuide.Add(15, "fifteen");
      translationGuide.Add(16, "sixteen");
      translationGuide.Add(17, "seventeen");
      translationGuide.Add(18, "eighteen");
      translationGuide.Add(19, "nineteen");
      translationGuide.Add(20, "twenty");
    }

    public NumberTranslator(int inputNumber)
    {
      _inputNumber = inputNumber;

      BuildDictionary();
    }

    public string TranslateNumber()
    {
      _returnWord = translationGuide[_inputNumber];

      return _returnWord;
    }


  }
}
