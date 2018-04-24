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
      if (_cent==0)
      {
        _allCoins.Add("No Change!");
      }
      else if (_cent>0 && _cent<5)
      {
          var numCents = _cent/1;
          _allCoins.Add(numCents.ToString() + " penny(s)");
      }
      else if (_cent>=5 && _cent<10)
      {
          var numNickels = _cent/5;
          var numCents = (_cent%5)/1;
          _allCoins.Add(numNickels.ToString() + " nickel(s)");
          _allCoins.Add(numCents.ToString() + " penny(s)");
      }
      else if (_cent>=10 && _cent<25)
      {
          var numDimes = _cent/10;
          var numNickels = (_cent%10)/5;
          var numCents = ((_cent%10)%5)/1;
          _allCoins.Add(numDimes.ToString() + " dime(s)");
          _allCoins.Add(numNickels.ToString() + " nickel(s)");
          _allCoins.Add(numCents.ToString() + " penny(s)");
      }
      else if (_cent>=25) {
        var numQuarters = _cent/25;
        var numDimes = (_cent%25)/10;
        var numNickels = ((_cent%25)%10)/5;
        var numCents = (((_cent%25)%10)%5)/1;
        _allCoins.Add(numQuarters.ToString() + " quarter(s)");
        _allCoins.Add(numDimes.ToString() + " dime(s)");
        _allCoins.Add(numNickels.ToString() + " nickel(s)");
        _allCoins.Add(numCents.ToString() + " penny(s)");
      }

    }

    public List<string> GetAll()
    {
      return _allCoins;
    }


  }
}
