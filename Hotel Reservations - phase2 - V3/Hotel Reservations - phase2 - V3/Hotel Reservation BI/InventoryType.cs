using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hotel_Reservations_BI
{
    public class InventoryType
    {
        List<InventoryType> RoomInventory;

        public string Date { get; set; }

        public string HotelId { get; set; }

        public string RoomType { get; set; } // King Bed(KB), Queen Bed(QB), Double Bed (DB)

        public int Quantity { get; set; } // how many of this room type for a hotel

        public InventoryType() { }

        public InventoryType(string Date, string HotelId, string RoomType, int Quantity)
        {
            this.Date = Date;
            this.HotelId = HotelId;
            this.RoomType = RoomType;
            this.Quantity = Quantity;
        }

        public List<InventoryType> GetRoomInventory(List<Hotel> h, DateTime from, DateTime to)
        {
            RoomInventory = new List<InventoryType>();

            DateTime startdt = new DateTime(from.Year, from.Month, from.Day);
            DateTime enddt = new DateTime(to.Year, to.Month, to.Day);

            for (DateTime dt = startdt; dt <= enddt; dt = dt.AddDays(1))
            {
                foreach (Hotel hotel in h)
                {
                    foreach (Room r in hotel.roomlist)
                    {
                        RoomInventory.Add(new InventoryType(dt.ToString("yyyyMMdd"), hotel.Id, r.ID.ToString(), 5));
                    }
                }
            }

            return RoomInventory;
        }
    }
}
