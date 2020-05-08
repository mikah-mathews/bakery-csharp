using System;
using System.Collections.Generic;

namespace BakeryOptions
{
  public class Program
  {
    public static void Main()
    {
      List<BakeryCart> Cart = new List<BakeryCart>();
      Console.WriteLine("Hello. Welcome to Red's Bakery.");
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
      Console.WriteLine("Do you want to add bread to your cart, add pastries to your cart, or checkout?");
      Console.WriteLine("bread || pastry || checkout || quit");
      string action = Console.ReadLine();
      while (action != "quit" || action != "Quit")
      {
        if (action == "checkout")
        {

        }
        else if (action == "bread")
        {

        }
        else if (action == "pastry")
        {

        }
        else
        {
          Console.WriteLine
        }
      }
    }
  }
}