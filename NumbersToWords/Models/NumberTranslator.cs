using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class NumberTranslator
  {
    private int _inputNumber;
    private string _returnWord;

    private Dictionary<int, string> translationGuide = new Dictionary<int, string> {};

    private Dictionary<int, string> translationGuideTenBase = new Dictionary<int, string> {};

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

      //Ten base
      translationGuideTenBase.Add(2,"twenty");
      translationGuideTenBase.Add(3,"thirty");
      translationGuideTenBase.Add(4,"fourty");
      translationGuideTenBase.Add(5,"fifty");
      translationGuideTenBase.Add(6,"sixty");
      translationGuideTenBase.Add(7,"seventy");
      translationGuideTenBase.Add(8,"eighty");
      translationGuideTenBase.Add(9,"ninety");

    }

    public NumberTranslator(int inputNumber)
    {
      _inputNumber = inputNumber;

      BuildDictionary();
    }

    public string TranslateToNintyNine()
    {
      string tenBase = "";

      if (_inputNumber <= 19)
      {
        tenBase = translationGuide[_inputNumber];
      }

      if (_inputNumber >= 20 && _inputNumber <= 99)
      {
        string inputNumberString = _inputNumber.ToString(); //convert user's int to string

        //grab the 0th index of the number string and translate it through the BaseTen Dictionary
        tenBase = translationGuideTenBase[int.Parse(inputNumberString[0].ToString())];

        //if it doesnt end in 0, then add on a - and parse the 1st index of the number string through the base0 dictionary to get appropriate word
        if (inputNumberString[1]!='0')
        {
          tenBase +="-";
          tenBase += translationGuide[int.Parse(inputNumberString[1].ToString())];
        }

        return tenBase;

      }

      return tenBase;
    }

    public string TranslateToNineNintyNine(int hundrethsDigit)
    {
      string hundrethsWord = translationGuide[hundrethsDigit];
      hundrethsWord += " hundred ";

      return hundrethsWord;
    }

    public string TranslateNumber()
    {
      int lengthOfNumber = _inputNumber.ToString().Length;
      string inputNumberString = _inputNumber.ToString();

      if (lengthOfNumber == 3)
      {
        _returnWord = TranslateToNineNintyNine(int.Parse(inputNumberString[0].ToString()));
        _returnWord += TranslateToNintyNine();
      }
      else if (lengthOfNumber < 3)
      {
        _returnWord += TranslateToNintyNine();
      }

      return _returnWord;
    }

  }
}
