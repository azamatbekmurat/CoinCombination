using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CoinCombs.Models;
using System;

namespace CoinCombs.Controllers
{
  public class HomeController : Controller
  {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }

        [HttpPost("cents")]
        public ActionResult Check()
        {
          int inputAmount = int.Parse(Request.Form["input-cents"]);
          CoinCombGen change = new CoinCombGen(inputAmount);
          change.ToChange();
          List<string> OutputCoins = change.GetAll();
          return View("Result", OutputCoins);
        }

  }
}
