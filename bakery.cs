using System;
using System.Collections.Generic;
using System.Linq;

namespace BakeryOptions
{
  public class BakeryCart
  {
    public string Bread { get; set; }
    public string Pastry { get; set; }
    public int Price { get; set; }

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

    public static string addBread
    {
      BakeStats["bread"] ++;
      return "You have " + BakeStats["bread"] + " in your cart.";
    }
    public static string addPastry
    {
      BakeStats["pastry"] ++;
      return "You have " + BakeStats["pastry"] + " in your cart.";
    }
    public static string total
    {
      int breadPrice = BakeStats["bread"] * 5;
      int pastryPrice = BakeStats["pastry"] * 2;
      return "Your bread price is: " + breadPrice + "\nYour pastry price is: " + pastryPrice;
    }
  }
}