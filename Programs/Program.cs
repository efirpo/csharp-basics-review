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
      Console.WriteLine("\n                         Welcome to\n\n'||''|.   ||                                  '                             \n ||   || ...    ....  ... ..  ... ..    ....     ....\n ||...|'  ||  .|...||  ||' ''  ||' '' .|...||   ||. '\n ||       ||  ||       ||      ||     ||        . '|.. \n.||.     .||.  '|...' .||.    .||.     '|...'   |'..|'\n\n                        '||''|.           '||\n                         ||   ||   ....    ||  ..    ....  ... ..  .... ... \n                         ||'''|.  '' .||   || .'   .|...||  ||' ''  '|.  |\n                         ||    || .|' ||   ||'|.   ||       ||       '|.|\n                        .||...|'  '|..'|' .||. ||.  '|...' .||.       '|    \n                                                                   .. |\n                                                                    ''\n======================================================\n\nBread costs $5.00 per loaf, and when you buy 2 you get 1 free!\n\nPastries cost $2.00, or 3 for $5.00!\n\nWould you like to place an order? [ Y / N ]\n\n======================================================\n");
      string confirm = (Console.ReadLine().ToLower());
      if (confirm == "y")
      {
        Console.WriteLine("\n======================================================\n\nWould you: \n\n1) Like to get your free bread loaves on top of your ordered amount\n\n\tor \n\n2) Order how many you want total and let us calculate how many should be free? \n\n\t[ 1 / 2 ]\n\n======================================================\n");
        string confirmBread = (Console.ReadLine().ToLower());
        Console.WriteLine("\nHow many loaves of bread would you like?\n\n======================================================\n");
        int breadOrder = int.Parse(Console.ReadLine());
        Console.WriteLine("\nHow many pastries would you like?\n\n======================================================\n");
        int pastryOrder = int.Parse(Console.ReadLine());
        Bread bread = new Bread(breadOrder, confirmBread);
        Pastry pastry = new Pastry(pastryOrder);
        Console.WriteLine("                                 ||             .\n... ..    ....    ....    ....  ...  ... ...  .||.\n ||' '' .|...|| .|   '' .|...||  ||   ||'  ||  ||\n ||     ||      ||      ||       ||   ||    |  ||\n.||.     '|...'  '|...'  '|...' .||.  ||...'   '|.'\n                                      ||  \n                                     ''''\n======================================================\n\nThank you for your order! Your order details are below.\n\n" + Bread.Bread.CalculateBread() + "\n" + Pastry.Pastry.CalculatePastry() + "\n\nYour total order will cost: $" + ((Bread.Bread._breadPrice) + (Pastry.Pastry._pastryPrice)) + ".00!\n\n======================================================\n\nWould you like to add anything to your order? [ Y / N ]\n======================================================\n");
        string addOrder = (Console.ReadLine().ToLower());
        if (addOrder == "y")
        {
          Console.WriteLine("\nAdd how many loaves of bread?\n======================================================\n");
          int addBread = int.Parse(Console.ReadLine());
          Bread._breadOrder += addBread;
          Console.WriteLine("\nAdd how many pastries?\n======================================================\n");
          int addPastry = int.Parse(Console.ReadLine());
          pastry._pastryOrder += addBread;
          Console.WriteLine("                                 ||             .\n... ..    ....    ....    ....  ...  ... ...  .||.\n ||' '' .|...|| .|   '' .|...||  ||   ||'  ||  ||\n ||     ||      ||      ||       ||   ||    |  ||\n.||.     '|...'  '|...'  '|...' .||.  ||...'   '|.'\n                                      ||  \n                                     ''''\n======================================================\n\nThank you for your order! Your order details are below.\n\n" + Bread.Bread.CalculateBread() + "\n" + Pastry.Pastry.CalculatePastry() + "\n\nYour total order will cost: $" + ((Bread.Bread._breadPrice) + (Pastry.Pastry._pastryPrice)) + ".00!\n\n======================================================\n\nWould you like to add anything to your order? [ Y / N ]\n======================================================\n");
        }
      }
      else if (confirm == "n")
      {
        Console.WriteLine("\n======================================================\n\nAll glutened out, huh? Thank you, come back sometime soon!\n\n======================================================\n");
      }
    }
  }


}