using System;
using System.Collections.Generic;

namespace BakeryOptions
{
  public class Carbs
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
      
    }
  }
}