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

      Console.WriteLine("\n                         Welcome to\n\n");
      Console.WriteLine(" ___  _                     _      ___       _                  ");
      Console.WriteLine("| . \\<_> ___  _ _  _ _  ___|/___  | . > ___ | |__ ___  _ _  _ _ ");
      Console.WriteLine("|  _/| |/ ._>| '_>| '_>/ ._><_-<  | . \\<_> || / // ._>| '_>| | |");
      Console.WriteLine("|_|  |_|\\___.|_|  |_|  \\___./__/  |___/<___||_\\_\\\\___.|_|  `_. |");
      Console.WriteLine("                                                           <___'\n");
      Console.WriteLine("\nBread costs $5.00 per loaf, and when you buy 2 you get 1 free!\n\nPastries cost $2.00, or 3 for $5.00!\n\nWould you like to place an order? [Y/N]");
      string confirm = (Console.ReadLine().ToLower());
      if (confirm == "y")
      {
        Console.WriteLine("How many loaves of bread would you like?");
        int breadOrder = int.Parse(Console.ReadLine());
        Console.WriteLine("How many pastries would you like?");
        int pastryOrder = int.Parse(Console.ReadLine());
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