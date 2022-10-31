using System.Collections.Generic;
using System.Drawing;

namespace DotNet.models
{
    public class Week
    {
        public int week;
        public int co2;
        public int positiveCustomerScore;
        public int negativeCustomerScore;
        public double budget;

        public int Week { get; set; }
        public int Co2 { get; set; }
        public int PositiveCustomerScore { get; set; }
        public int NegativeCustomerScore { get; set; }
        public double Budget { get; set; }
    }
}