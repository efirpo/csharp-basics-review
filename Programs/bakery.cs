using System;
using System.Collections.Generic;

namespace Bakery.Order
{
  public class Bread
  {
    public int _breadOrder { get; set; }

    public Bread(int amount)
    {
      _breadOrder = amount;
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
    }
  }

}