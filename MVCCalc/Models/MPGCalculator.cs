using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCalc.Models
{
    public class MPGCalculator
    {
        public double CalculateMPG(double miles, double gallons) {
            return miles / gallons;
        }
    }
}