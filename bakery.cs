using System;
using System.Collections.Generic;

namespace BakeryOptions
{
  public class BakeryCart
  {
    public string Bread { get; set;}
    public string Pastry { get; set;}
    public int Price {get; set;}

    public static Dictionary<string, int> BakeStats;

    public BakeryCart(string numberOfBread, string numberOfPastry, int total)
    {
      Bread = numberOfBread;
      Pastry = numberOfPastry;
      Price = total;
      BakeStats = new Dictionary<string, int>();
      BakeStats.Add("Bread", 0);
      BakeStats.Add("Pastry", 0);
    }

    public static string addBread
    {
      BakeStats["Bread"] ++;
      Console.WriteLine("You have " + BakeStats["Bread"] + " in your cart.");
    }
    public static string addPastry
    {
      BakeStats["Pastry"] ++;
      Console.WriteLine("You have " + BakeStats["Pastry"] + " in your cart.");
    }
    public static string total
    {
      int breadPrice = BakeStats["Bread"] * 5;
      int pastryPrice = BakeStats["Pastry"] * 2;
      return "Your bread price is: " + breadPrice + "\nYour pastry price is: " + pastryPrice;
    }
  }
}