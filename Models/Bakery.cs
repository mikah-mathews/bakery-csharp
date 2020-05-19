using System;
using System.Collections.Generic;
using System.Linq;

namespace BakeryOptions
{
  public class BakeryCart
  {
    public string Bread { get; set; }
    public string Pastry { get; set; }
    public string Price { get; set; }
    public static Dictionary<string, int> BakeStats;
    public BakeryCart(string numberOfBread, string numberOfPastry, string total)
    {
      Bread = numberOfBread;
      Pastry = numberOfPastry;
      Price = total;
      BakeStats = new Dictionary<string, int>();
      BakeStats.Add("bread", 0);
      BakeStats.Add("pastry", 0);
    }

    public static string addBread()
    {
      BakeStats["bread"] ++;
      if (BakeStats["bread"] <= 1)
      {
        return "You have " + BakeStats["bread"] + " loaf of bread in your cart.";
      }
      else if (BakeStats["bread"] == 2)
      {
        BakeStats["bread"] ++;
        return "You have 2 loaves of bread in your cart. Your third loaf is free! It has been added to the cart!";
      }
      else if (BakeStats["bread"] > 1)
      {
        return "You have " + BakeStats["bread"] + " loaves of bread in your cart.";
      }
      else
      {
        return "There is an error??? in addBread";
      }
      
    }

    public static string addPastry()
    {
      BakeStats["pastry"] ++;
      if (BakeStats["pastry"] <= 1)
      {
        return "You have " + BakeStats["pastry"] + " pastry in your cart.";
      } 
      else if (BakeStats["pastry"] > 1)
      {
        return "You have " + BakeStats["pastry"] + " pastries in your cart.";
      }
      else
      {
        return "There is an error??? in pastry";
      }
      
    }
    public static string total()
    {
      int breadPrice = BakeStats["bread"] * 5;
      int discountedBread = (int)Math.Floor((decimal)BakeStats["bread"] / 2);
      int discountBreadPrice = discountedBread * 5;
      int finalBreadPrice = (breadPrice - discountBreadPrice);
      int pastriesForFive = BakeStats["pastry"] / 3;
      int pastriesForTwo = BakeStats["pastry"] % 3;
      int finalPastryPrice = ((pastriesForFive * 5) + (pastriesForTwo * 2));
      int totalPrice = finalBreadPrice + finalPastryPrice;
      return "Your bread price is: " + finalBreadPrice + " usd\nYour pastry price is: " + finalPastryPrice + "usd\nYour total is " + totalPrice + " usd";

    }
  }
}