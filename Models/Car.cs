using System;

namespace Dealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    public int SalesPrice { get; set;}

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      SalesPrice = Price;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    public static string MakeSound(string sound)
    {
      return "This car sounds like " + sound;
    }

    public int NewSalesPrice(int discount)
    {
      // return "The discounted price is: " + (price/discount);
      int temp = discount/100;
      int temp1 = 1-temp;
      // return "The discounted price is " + Price*(1-(discount/100));
      // SalesPrice = Price*(1-(discount/100));
      return (Price * temp1);
      // return (SalesPrice / discount);
    }
  }
}