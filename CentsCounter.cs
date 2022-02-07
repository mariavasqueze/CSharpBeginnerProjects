// Cents counter.

using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      
      Console.WriteLine("What's the dollar amount to convert to coins? ");
      string dollarAmountString = Console.ReadLine();
      double dollarAmountDouble = Convert.ToDouble(dollarAmountString);
      Console.WriteLine($"{dollarAmountDouble} cents is equal to ... ");
      
      //Coin Values
      int goldValue = 10;
      int silverValue = 5;
      int bronzeValue = 1;

      // Coin value calculations
      double goldCoins = Math.Floor(dollarAmountDouble / goldValue); 
      double goldRemaining = dollarAmountDouble % goldValue;

      double silverCoins = Math.Floor(goldRemaining / silverValue);
      double silverRemaining = (goldRemaining % silverValue);

      double bronzeCoins = Math.Floor(silverRemaining / bronzeValue);

      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver Coins: {silverCoins}");
      Console.WriteLine($"Bronze Coins: {bronzeCoins}");
    }
  }
}
