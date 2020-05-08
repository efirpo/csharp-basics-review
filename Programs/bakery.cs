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
    public string _orderType { get; set; }

    public Bread(int amount, string type)
    {
      _breadOrder = amount;
      _orderType = type;
    }

    public string CalculateBread()
    {
      if (_orderType == "1")
      {
        _breadPrice = _breadOrder * 5;
        _freeLoaves = (_breadOrder / 2);
        _loaves = _freeLoaves + _breadOrder;
      }
      else if (_orderType == "2")
      {
        if (_breadOrder > 2)
        {
          _breadPrice = ((((_breadOrder - (_breadOrder % 3)) / 3) * 10) + ((_breadOrder % 3) * 5));
          _loaves = _breadOrder;
          _freeLoaves = (_breadOrder / 3);
        }

      }
      return "Your bread order will cost: $" + _breadPrice + ".00, and you will receive a total of " + _loaves + " loaves, of which " + _freeLoaves + " are on the house!";
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
        _pastryPrice = ((((_pastryOrder - (_pastryOrder % 3)) / 3) * 5) + ((_pastryOrder % 3) * 2));
      }
      else if (_pastryOrder == 3)
      {
        _pastryPrice = 5;
      }
      else if (_pastryOrder < 3)
      {
        _pastryPrice = _pastryOrder * 2;
      }
      return "Your pastry order will cost: $" + _pastryPrice + ".00, and you're getting " + _pastryOrder + " of them.";
    }
  }

}
