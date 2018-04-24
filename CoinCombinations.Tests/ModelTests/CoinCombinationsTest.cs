using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombs.Models;
using System.Collections.Generic;

namespace CoinCombs.Tests
{
  [TestClass]
  public class CoinCombGenTest
  {
    [TestMethod]
    public void IsPing_NumberDivisibleByThree_True()
    {
      CoinCombGen testCoinComb = new CoinCombGen(25);
      testCoinComb.ToChange();
      List<string> OutputCoins = testCoinComb.GetAll();
      Assert.AreEqual("1", OutputCoins);
    }

  }
}
