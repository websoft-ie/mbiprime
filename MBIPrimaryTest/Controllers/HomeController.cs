using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace MBIPrimaryTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        
        
        [HttpPost]
        public ActionResult Index(int max)
        {
            ViewBag.Primes = Util.GetPrimesUpTo(max);
            return View();
        }

        [HttpPost]
        public ActionResult GetMyList(int numberLimit)
        {
            ViewBag.Primes = Util.GetPrimesUpTo(numberLimit);
            return View("Index");
        }
    }

    public static class Util
    {
        public static string GetPrimesUpTo(int max)
        {
            List<string> result = new List<string>();

            for (int i = 1; i <= max; i++)
            {
                bool isPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    result.Add(i.ToString());
            }

            return String.Join(",", result);
        }
    }
}