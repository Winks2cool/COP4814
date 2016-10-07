using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservations_BI
{
    public class Distance
    {
        public double Beach { get; set; }

        public double Shopping { get; set; }

        public double Airport { get; set; }

        public Distance() { }

        public Distance(double Beach, double Shopping, double Airport)
        {
            this.Beach = Beach;
            this.Shopping = Shopping;
            this.Airport = Airport;
        }
    }
}
