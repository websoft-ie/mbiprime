using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MBIPrimaryTest.Models;
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
        public ActionResult GetMyList(int numberLimit= 1)
        {
            try
            {
                if (numberLimit > 1 && numberLimit<100001)
                {
                    ViewBag.Status = true;
                    var model = Util.GetPrimesUpTo(numberLimit);
                    return View("Index", null, model);
                }
                
            }
            catch (Exception)
            {
                // ignored
            }

            ViewBag.Status = false;
            return View("Index");


        }
    }

   
}