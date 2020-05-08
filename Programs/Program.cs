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
      Console.WriteLine("'||''|.   ||                                  '                             ");
      Console.WriteLine(" ||   || ...    ....  ... ..  ... ..    ....     ....                       ");
      Console.WriteLine(" ||...|'  ||  .|...||  ||' ''  ||' '' .|...||   ||. '                       ");
      Console.WriteLine(" ||       ||  ||       ||      ||     ||        . '|..                      ");
      Console.WriteLine(".||.     .||.  '|...' .||.    .||.     '|...'   |'..|'                      \n\n");
      Console.WriteLine("                        '||''|.           '||                               ");
      Console.WriteLine("                         ||   ||   ....    ||  ..    ....  ... ..  .... ... ");
      Console.WriteLine("                         ||'''|.  '' .||   || .'   .|...||  ||' ''  '|.  |  ");
      Console.WriteLine("                         ||    || .|' ||   ||'|.   ||       ||       '|.|   ");
      Console.WriteLine("                        .||...|'  '|..'|' .||. ||.  '|...' .||.       '|    ");
      Console.WriteLine("                                                                   .. |     ");
      Console.WriteLine("                                                                    ''     ");

      Console.WriteLine("\nBread costs $5.00 per loaf, and when you buy 2 you get 1 free!\n\nPastries cost $2.00, or 3 for $5.00!\n\nWould you like to place an order? [Y/N]");
      string confirm = (Console.ReadLine().ToLower());
      if (confirm == "y")
      {
        Console.WriteLine("Would you \n\t1) Like to get extra bread loaves on top of your ordered amount\n\n\tor \n\n\t2) Order how many you want total and let us calculate how many should be free? [ 1 / 2 ]");
        string confirmBread = (Console.ReadLine().ToLower());
        Console.WriteLine("\nHow many loaves of bread would you like?");
        int breadOrder = int.Parse(Console.ReadLine());
        Console.WriteLine("\nHow many pastries would you like?");
        int pastryOrder = int.Parse(Console.ReadLine());
        Bread bread = new Bread(breadOrder, confirmBread);
        Pastry pastry = new Pastry(pastryOrder);
        Console.WriteLine("\nThank you for your order! Your order details are below.");
        Console.WriteLine("\n" + bread.CalculateBread());
        Console.WriteLine("\n" + pastry.CalculatePastry());
        Console.WriteLine("\nYour total order will cost: $" + ((bread._breadPrice) + (pastry._pastryPrice)) + ".00!");



      }
      else
      {
        Console.WriteLine("All glutened out, huh? Thank you, come back sometime soon!");
      }
    }
  }


}