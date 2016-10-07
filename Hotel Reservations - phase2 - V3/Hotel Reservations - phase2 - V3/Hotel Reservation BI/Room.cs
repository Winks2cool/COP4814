using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservations_BI
{
    public class Room
    {
        public string ID { get; set; } //King Bed(KB), Queen Bed(QB), Double Bed (DB)
        public double DailyRate { get; set; }

        public string Capacity { get; set; }

        

        public Room() { }

        public Room (string id, double dailyRate, string capacity)
        {
            
            this.ID = id;
            DailyRate = dailyRate;
            Capacity = capacity;
        }
    }

}
