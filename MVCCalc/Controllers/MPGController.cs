using MVCCalc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCalc.Controllers
{
    public class MPGController : Controller
    {
        //
        // GET: /MPG/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(double miles, double gallons)
        {
            MPGCalculator calc = new MPGCalculator();
            // how to get this into the view?
            double result = calc.CalculateMPG(miles, gallons);
            return View(String.Format("{0:0.0}", result));
        }
	}
}