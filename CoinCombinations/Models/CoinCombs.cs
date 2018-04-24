using System.Collections.Generic;
using System;

namespace CoinCombs.Models
{
  public class CoinCombGen
  {
    private int _cent;

    private List<string> _allCoins = new List<string>();

    public CoinCombGen(int Cent)
    {
      _cent = Cent;
    }

    public int GetAmount()
    {
      return _cent;
    }

    public void ToChange()
    {
      // int [] coins = new int[4] {25, 10, 5, 1};

      if (_cent>=25)
      {
        var numQuarters = _cent/25;
        _allCoins.Add(numQuarters.ToString() + " quarter(s)");
      } else {
        var remainder = _cent%25;
        _allCoins.Add(remainder.ToString());
      }
    }

    public List<string> GetAll()
    {
      return _allCoins;
    }


  }
}
