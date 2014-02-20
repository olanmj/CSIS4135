using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCalc.Models
{
    public class MPGCalculator
    {
        public double Gallons { get; set; }
        public double Miles { get; set; }

        public double CalculateMPG(double miles, double gallons) {
            return miles / gallons;
        }
    }
}