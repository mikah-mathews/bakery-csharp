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
      return "You have " + BakeStats["bread"] + " bread in your cart.";
    }
    public static string addPastry()
    {
      BakeStats["pastry"] ++;
      return "You have " + BakeStats["pastry"] + " pastry in your cart.";
    }
    public static string total()
    {
      int breadPrice = BakeStats["bread"] * 5;
      int discountedBread = (int)Math.Floor((decimal)BakeStats["bread"] / 2);
      int discountBreadPrice = discountedBread * 5;
      int pastryPrice = BakeStats["pastry"] * 2;
      int totalPrice = (breadPrice - discountBreadPrice) + pastryPrice;
      return "Your bread price is: " + breadPrice + " usd\nYour pastry price is: " + pastryPrice + "usd\nYour total is " + totalPrice + " usd";

    }
  }
}