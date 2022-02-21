using System;

namespace Dealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }

    // public string MakeModel
    // {
    //   get
    //   {
    //     return "That's a big secret. You'll have to visit Lonny's to find out about our special deals!";
    //   }
    //   set
    //   {
    //     _makeModel = value;
    //   }
    // }

    // public void SetPrice(int newPrice)
    // {
    //   _price = newPrice;
    // }

    // public int GetPrice()
    // {
    //   return _price;
    // }

    // public int GetMiles()
    // {
    //   return _miles;
    // }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    public static string MakeSound(string sound)
    {
      return "This car sounds like " + sound;
    }
  }
}