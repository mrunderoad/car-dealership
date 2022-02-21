using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{
  public class Program
  {
    public static void  Main()
    {
      Car volkswagen = new Car(1974, "Volkswagen Thing", 7000, 368792);
      Car yugo = new Car(1980, "Yugo Koral", 6000, 56000);
      Car ford = new Car(1988, "Ford Country Squire", 12000, 239001);
      Car amc = new Car(1976, "AMC Pacer", 5000, 198000);
      Car fast = new Car(2020, "Ferrari X600", 100000, 10000);

      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc, fast };

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      List<Car> CarsMatchingSearch = new List<Car>(0);
      
      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }

      Console.WriteLine("Enter your season: ");
      string stringSeasonDiscount = Console.ReadLine();

      bool summer = stringSeasonDiscount == "summer";
      bool spring = stringSeasonDiscount == "spring";
      int discount = 0;

      if (summer)
    {
      discount = 5;
    }
      else if (spring)
    {
      discount = 2;
    }
      else
    {
      discount = 0;
    }

      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine("----------------------");
        Console.WriteLine(automobile.Year);
        Console.WriteLine(automobile.MakeModel); 
        Console.WriteLine(automobile.Miles + " miles");
        Console.WriteLine("$" + automobile.RetailPrice);
        Console.WriteLine("This car's resale value is: " + automobile.ResaleValue(automobile.Year));
        Console.WriteLine(Car.MakeSound("vroom vroom beep beep"));
        Console.WriteLine("Your discounted price is: $" + automobile.NewSalesPrice(discount));
      }
    }
  }
}