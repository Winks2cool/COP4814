using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservations_BI
{
    public class HotelListItem
    {
        
        public string ID { get; set; }

        public string Name { get; set; }

        public double Rating { get; set; }

        public List<Room> roomTypes { get; set; }



        public HotelListItem()
        {
            roomTypes = new List<Room>();    
        }

        public HotelListItem(string id, string name, double rating)
        {
            ID = id;
            Name = name;
            Rating = rating;
            roomTypes = new List<Room>();

        }
        public void getRoomTypes(Room _roomtype)
        {
            roomTypes.Add(_roomtype);
        }
    }
}
