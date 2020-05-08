using System;
using System.Collections.Generic;
using System.Linq;
using Bakery.Order;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {

      Console.WriteLine("Welcome to Pierre's Bakery!\n\nBread costs $5.00 per loaf, and if you buy 2 you get 1 free!\n\nPastries cost $2.00, or 3 for $5.00!\n\nWould you like to place an order? [Y/N]");
      string confirm = (Console.ReadLine().ToLower());
      if (confirm == "y")
      {
        Console.WriteLine("How many loaves of bread would you like?");
        int breadOrder = Console.Read();
        Console.WriteLine("How many pastries would you like?");
        int pastryOrder = Console.Read();
        Bread bread = new Bread(breadOrder);
        Pastry pastry = new Pastry(pastryOrder);
        Console.WriteLine("Thank you for your order! Your order details are below.");
        Console.WriteLine(bread.CalculateBread());
        Console.WriteLine(pastry.CalculatePastry());



      }
      else
      {
        Console.WriteLine("All glutened out, huh? Thank you, come back sometime soon!");
      }
    }
  }


}