using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCalc.Models
{
    public class MPGCalculator
    {
        private double miles;
        private double gallons;

        public double CalculateMPG(double miles, double gallons) {
            return miles / gallons;
        }
    }
}