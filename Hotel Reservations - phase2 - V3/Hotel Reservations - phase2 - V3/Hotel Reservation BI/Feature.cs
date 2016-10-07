using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservations_BI
{
   public class Feature

    {
        public bool Laundry { get; set; }

        public bool Aircon { get; set; }

        public bool Breakfast { get; set; }

        public bool Shuttle { get; set; }

        //public Distance Distance { get; set; }

        public Feature() { }

        public Feature (bool Laundry, bool Aircon, bool Breakfast, bool Shuttle)
        {
            this.Laundry = Laundry;
            this.Aircon = Aircon;
            this.Breakfast = Breakfast;
            this.Shuttle = Shuttle;
            //Distance = new Distance();
        }



    }
}
