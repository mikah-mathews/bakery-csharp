using System;
using System.Collections.Generic;

namespace BakeryOptions
{
  public class Program
  {
    public static void Main()
    {
      List<BakeryCart> Cart = new List<BakeryCart>();
      Cart.Add(new BakeryCart("0", "0", "0"));
      Console.WriteLine("\nHello. Welcome to Red's Bakery.");
      Console.WriteLine("----------");
      Console.WriteLine("|| Menu ||");
      Console.WriteLine("~~~~~~~~~~");
      Console.WriteLine("One Bread Loaf - 5 usd");
      Console.WriteLine("One Pastry - 2 usd");
      Console.WriteLine("~~~~~~~~~~");
      Console.WriteLine("|| Deals ||");
      Console.WriteLine("Bread - Buy 2 get 1 free");
      Console.WriteLine("Pastries - Buy 3 for 5 usd");
      Console.WriteLine("----------");
      Console.WriteLine("Do you want to add bread to your cart, add pastries to your cart, checkout or quit?");
      Console.WriteLine("All commands are case sensitive, so please type without Capslock");
      Console.WriteLine("bread || pastry || checkout || quit");
      string action = Console.ReadLine();
      while (action != "quit" || action != "Quit")
      {
        Console.WriteLine("----------");
        if (action == "checkout")
        {
          Console.WriteLine(BakeryCart.total());
        }
        else if (action == "bread")
        {
          Console.WriteLine(BakeryCart.addBread());
        }
        else if (action == "pastry")
        {
          Console.WriteLine(BakeryCart.addPastry());
        }
        else if (action == "quit" || action == "Quit")
        {
          Console.WriteLine("See you! Please come again.");
          break;
        }
        else
        {
          Console.WriteLine("Command not recognized, please try again");
        }

        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("----------");
        Console.WriteLine("Do you want to add bread to your cart, add pastries to your cart, checkout, or quit?");
        Console.WriteLine("All commands are case sensitive, so please type without Capslock");
        Console.WriteLine("bread || pastry || checkout || quit");
        action = Console.ReadLine();
      }
    }
  }
}
