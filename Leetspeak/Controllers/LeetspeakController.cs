using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Leetspeak.Models;

namespace Leetspeak.Controllers
{
  public class LeetspeakController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/")]
    public ActionResult Display()
    {
      LeetspeakGenerator newLeetspeakGenerator = new LeetspeakGenerator();
      string model = newLeetspeakGenerator.Leetspeak(Request.Form["input-string"]);
      return View("Display", model);
    }

  }
}
