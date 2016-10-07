using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Xsl;


namespace Hotel_Reservations_BI
{
    public class HotelFactory
    {
        StreamWriter sw;
        XmlSerializer serial;
        List<Hotel> hotelList;
        List<HotelListItem> HListItems;

        public List<Hotel> CreateNewHotel()
        {
           
            hotelList = new List<Hotel>();
            Hotel hotel = new Hotel("000111", "Courtyard Suites", "2012 North Hwy, Key Largo, FL 33032", 4.5);
            hotel.AddFeatures(true, true, false, false);
            hotel.AddDistances(0.2, 2.5, 5.3);
            hotel.AddRoom(new Room("KB", 140.00, "2/0"));
            hotel.AddRoom(new Room("QB", 120.00, "2/0"));
            hotel.AddRoom(new Room("DB", 130.00, "2/0"));
            hotel.AddRoom(new Room("BS", 230.00, "2/0"));
            
            hotelList.Add(hotel);

            hotel = new Hotel("000222", "Best Eastern Inn", "4999 North Hwy, Key Largo, FL 33032", 3.5);
            hotel.AddFeatures(true, false, true, false);
            hotel.AddDistances(2.0, 3.5, 5.9);
            hotel.AddRoom(new Room("KB", 150.00, "2/0"));
            hotel.AddRoom(new Room("QB", 120.00, "2/0"));
            hotel.AddRoom(new Room("DB", 140.00, "2/0"));
            hotel.AddRoom(new Room("BS", 280.00, "2/0"));
            hotelList.Add(hotel);

            hotel = new Hotel("000333", "Gil's One Stop Palace", "107 SW 8th Ave, Miami, FL 33156", 3.0);
            hotel.AddFeatures(false, true, true, false);
            hotel.AddDistances(2.0, 3.5, 5.9);
            hotel.AddRoom(new Room("KB", 120.00, "2/0"));
            hotel.AddRoom(new Room("QB", 100.00, "2/0"));
            hotel.AddRoom(new Room("DB", 110.00, "2/0"));
            hotel.AddRoom(new Room("BS", 200.00, "2/0"));
            hotelList.Add(hotel);

            hotel = new Hotel("000444", "Emilo's Inn", "3918 Collins Ave, Miami Beach, FL 33140", 2.5);
            hotel.AddFeatures(false, true, true, false);
            hotel.AddDistances(2.0, 3.5, 5.9);
            hotel.AddRoom(new Room("KB", 130.00, "2/0"));
            hotel.AddRoom(new Room("QB", 110.00, "2/0"));
            hotel.AddRoom(new Room("DB", 120.00, "2/0"));
            hotel.AddRoom(new Room("BS", 195.00, "2/0"));
            hotelList.Add(hotel);

            hotel = new Hotel("000555", "BaySide Resort", "113 Biscayne Blvd, Miami, FL 33132", 4.5);
            hotel.AddFeatures(false, true, false, false);
            hotel.AddDistances(3.0, 1.5, 4.9);
            hotel.AddRoom(new Room("KB", 100.00, "2/0"));
            hotel.AddRoom(new Room("QB", 90.00, "2/0"));
            hotel.AddRoom(new Room("DB", 80.00, "2/0"));
            hotel.AddRoom(new Room("BS", 155.00, "2/0"));
            hotelList.Add(hotel);

            hotel = new Hotel("000666", "Annehart and Mcdaughty's Fireside Resort", "35165 South Dixie Hwy, Homestead, FL 33190", 1.5);
            hotel.AddFeatures(false, true, false, true);
            hotel.AddDistances(2.0, 6.5, 4.9);
            hotel.AddRoom(new Room("KB", 135.00, "2/0"));
            hotel.AddRoom(new Room("QB", 120.00, "2/2"));
            hotel.AddRoom(new Room("DB", 125.00, "2/0"));
            hotel.AddRoom(new Room("BS", 195.00, "2/0"));
            hotelList.Add(hotel);

            hotel = new Hotel("000777", "Marriott at Dadeland", "7740 North Kendall Drive, Miami, FL 33156", 4.0);
            hotel.AddFeatures(true, true, false, true);
            hotel.AddDistances(2.0, 6.5, 4.9);
            hotel.AddRoom(new Room("KB", 155.00, "2/0"));
            hotel.AddRoom(new Room("QB", 140.00, "2/2"));
            hotel.AddRoom(new Room("DB", 145.00, "2/0"));
            hotel.AddRoom(new Room("BS", 195.00, "2/0"));
            hotelList.Add(hotel);

            hotel = new Hotel("000888", "Courtyard Nautica", "11200 NW 79th Ave, Doral, FL 33137", 4.5);
            hotel.AddFeatures(true, true, false, true);
            hotel.AddDistances(5.0, 3.5, 4.9);
            hotel.AddRoom(new Room("KB", 165.00, "2/0"));
            hotel.AddRoom(new Room("QB", 150.00, "2/2"));
            hotel.AddRoom(new Room("DB", 155.00, "2/0"));
            hotel.AddRoom(new Room("BS", 295.00, "2/0"));
            hotelList.Add(hotel);

            hotel = new Hotel("000999", "Bedside Manners Inn", "157 Washington Ave, Miami Beach, FL 33141", 5.0);
            hotel.AddFeatures(true, true, true, true);
            hotel.AddDistances(2.0, 1.5, 3.9);
            hotel.AddRoom(new Room("KB", 185.00, "2/0"));
            hotel.AddRoom(new Room("QB", 170.00, "2/2"));
            hotel.AddRoom(new Room("DB", 177.00, "2/0"));
            hotel.AddRoom(new Room("BS", 395.00, "2/0"));
            hotelList.Add(hotel);

            hotel = new Hotel("0001000", "Western Social", "8633 North Hwy, Key Largo, FL 33033", 2.0);
            hotel.AddFeatures(true, true, true, true);
            hotel.AddDistances(2.0, 1.5, 3.9);
            hotel.AddRoom(new Room("KB", 195.00, "2/0"));
            hotel.AddRoom(new Room("QB", 180.00, "2/2"));
            hotel.AddRoom(new Room("DB", 187.00, "2/0"));
            hotel.AddRoom(new Room("BS", 395.00, "2/0"));
            hotelList.Add(hotel);


            return hotelList;
        }

        public void HotelXMLSerializer(List<Hotel> h, string filename)
        {
            serial = new XmlSerializer(h.GetType());
            sw = new StreamWriter(filename);
            serial.Serialize(sw, h);
            sw.Close();
        }

        public void HotelXMLSerializer(List<InventoryType> h, string filename)
        {
            serial = new XmlSerializer(h.GetType());
            sw = new StreamWriter(filename);
            serial.Serialize(sw, h);
            sw.Close();
        }
        public void HotelListItemXMLSerializer(List<HotelListItem> hli, string filename)
        {
            
            
            serial = new XmlSerializer(hli.GetType());
            sw = new StreamWriter(filename);
            serial.Serialize(sw, hli);
            sw.Close();
        }
        public List<Hotel> HotelXMLDeserializer(List<Hotel> h, string filename)
        {
            
            StreamReader sr = new StreamReader(filename);
            serial = new XmlSerializer(h.GetType());
            h = (List<Hotel>)serial.Deserialize(sr);
            sr.Close();

            return h;
        }
        public List<RoomType> roomDeserialer(List<RoomType> rl, string filename)
        {
            StreamReader sr = new StreamReader(filename);
            serial = new XmlSerializer(rl.GetType());
            rl = (List<RoomType>)serial.Deserialize(sr);
            sr.Close();

            return rl;
        }

        public List<HotelListItem> GetListOfHotels(List<RoomType> roomtypes, List<Hotel> hotelList)
        {
            HListItems = new List<HotelListItem>();
            

            HotelListItem hItem;
            RoomType rmtype = new RoomType();
            foreach (Hotel h in hotelList)
            {
                hItem = new HotelListItem(h.Id, h.Name, h.Rating);
                HListItems.Add(hItem);
                foreach (Room r in h.roomlist)
                {
                    string RoomName = rmtype.GetRoomName(roomtypes, r.ID);

                    hItem.getRoomTypes(new Room(r.ID.Replace(r.ID, RoomName), r.DailyRate, r.Capacity));
                } 
            }


            return HListItems;
        }




    }
}
