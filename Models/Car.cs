using System;

namespace Dealership.Models
{
  public class Car
  {
    public int Year { get; set; }
    public string MakeModel { get; set; }
    public int RetailPrice { get; set; }
    public int Miles { get; set; }
    public int SalesPrice { get; set;}
    public int CurrentPrice { get; set;}
    public Car( int year, string makeModel, int retailPrice, int miles)
    {
      Year = year;
      MakeModel = makeModel;
      RetailPrice = retailPrice;
      Miles = miles;
      CurrentPrice = RetailPrice;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (RetailPrice <= maxPrice);
    }

    public static string MakeSound(string sound)
    {
      return "This car sounds like " + sound;
    }

    public int NewSalesPrice(int discount)
    {
      SalesPrice = (RetailPrice*(100-discount))/100;
      return (SalesPrice);
    }

    public int ResaleValue(int year)
    {
      int age = 2022 - year;

      for (int i = 0; i <= age; i++)
      {
      CurrentPrice = (CurrentPrice*95)/100;
      }
      return CurrentPrice;
    }
  }
}