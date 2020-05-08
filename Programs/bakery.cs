using System;
using System.Collections.Generic;

namespace Bakery.Order
{
  public class Bread
  {
    public int _breadOrder { get; set; }
    public int _breadPrice { get; set; }
    public int _loaves { get; set; }
    public int _freeLoaves { get; set; }

    public Bread(int amount)
    {
      _breadOrder = amount;
    }

    public string CalculateBread()
    {

      if (_breadOrder > 2)
      {
        _breadPrice = ((((_breadOrder - (_breadOrder % 3)) / 3) * 10) + ((_breadOrder % 3) * 5));
        _loaves = _breadOrder;
        if (_breadOrder % 3 == 2)
        {
          _freeLoaves += 1;
        }
        else if (_breadOrder % 3 < 2)
        {
          _freeLoaves = (_breadOrder - (_breadOrder / 3));
        }
      }
      else if (_breadOrder < 2)
      {
        _breadPrice = 5;
        _loaves = 1;
        _freeLoaves = 0;
      }
      else if (_breadOrder == 2)
      {
        _breadPrice = 10;
        _loaves = 3;
        _freeLoaves = 1;
      }
      return "Your bread order will cost: $" + _breadPrice + ".00, and you're getting " + _loaves + " with " + _freeLoaves + " free loaves!";
    }
  }

  public class Pastry
  {
    public int _pastryOrder { get; set; }
    public int _pastryPrice { get; set; }
    public Pastry(int amount)
    {
      _pastryOrder = amount;

    }

    public string CalculatePastry()
    {
      if (_pastryOrder > 3)
      {
        _pastryPrice = (((_pastryOrder - (_pastryOrder % 3) / 3) * 5) + ((_pastryOrder % 3) * 2));
      }
      else if (_pastryOrder == 3)
      {
        _pastryPrice = 5;
      }
      else if (_pastryOrder < 3)
      {
        _pastryPrice = _pastryOrder * 2;
      }
      return "Your pastries will cost: $" + _pastryPrice + ".00";
    }
  }

}