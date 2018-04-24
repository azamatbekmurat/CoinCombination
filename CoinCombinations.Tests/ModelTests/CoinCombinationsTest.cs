using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombs.Models;
using System.Collections.Generic;
using System;

namespace CoinCombs.Tests
{
  [TestClass]
  public class CoinCombGenTest
  {
    [TestMethod]
    public void Change_GivesCoin_25()
    {
      CoinCombGen testCoinComb = new CoinCombGen(25);
      testCoinComb.ToChange();
      List<string> OutputCoins = testCoinComb.GetAll();
      List<string> ExpectedCoins = new List<string>() {
        "1 quarter(s)",
        "0 dime(s)",
        "0 nickel(s)",
        "0 penny(s)"
      };
            // Console.WriteLine to see what elements in the List
            foreach(var item in OutputCoins)
            {
              Console.WriteLine(item);
            }
      CollectionAssert.AreEqual(ExpectedCoins, OutputCoins);
    }

    [TestMethod]
    public void Change_GivesMultipleCoins_26()
    {
      CoinCombGen testCoinComb = new CoinCombGen(26);
      testCoinComb.ToChange();
      List<string> OutputCoins = testCoinComb.GetAll();
      List<string> ExpectedCoins = new List<string>() {
        "1 quarter(s)",
        "0 dime(s)",
        "0 nickel(s)",
        "1 penny(s)"
      };
            // Console.WriteLine to see what elements in the List
            foreach(var item in OutputCoins)
            {
              Console.WriteLine(item);
            }

      CollectionAssert.AreEqual(ExpectedCoins, OutputCoins);
    }

    [TestMethod]
    public void Change_GivesMultipleCoins_94()
    {
      CoinCombGen testCoinComb = new CoinCombGen(94);
      testCoinComb.ToChange();
      List<string> OutputCoins = testCoinComb.GetAll();
      List<string> ExpectedCoins = new List<string>() {"3 quarter(s)", "1 dime(s)", "1 nickel(s)", "4 penny(s)"};
            // Console.WriteLine to see what elements in the List
            foreach(var item in OutputCoins)
            {
              Console.WriteLine(item);
            }

      CollectionAssert.AreEqual(ExpectedCoins, OutputCoins);
    }

  }
}
