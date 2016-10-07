using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hotel_Reservations_BI
{
    public class Hotel


    {
        
        public string Id { get; set; }

        public string Name { get; set; }
        public double Rating { get; set; }

        public string Address { get; set; }

        public Feature Features { get; set; }
        public Distance Distances { get; set; }
        public List<Room> roomlist { get; set; }


        public Hotel(){
            Features = new Feature();
            Distances = new Distance();
            roomlist = new List<Room>();

        }

        public Hotel(string Id, string Name, string Address, double Rating)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            this.Rating = Rating;
            Features = new Feature();
            Distances = new Distance();
            roomlist = new List<Room>();
        }

        public void AddFeatures(bool Laundry, bool Aircon, bool Breakfast, bool Shuttle)
        {
            Features.Laundry = Laundry;
            Features.Aircon = Aircon;
            Features.Breakfast = Breakfast;
            Features.Shuttle = Shuttle;
        }
        public void AddDistances(double beach, double shopping, double airport)
        {
            Distances.Beach = beach;
            Distances.Shopping = shopping;
            Distances.Airport = airport;
        }
        public void AddRoom(Room room)
        {
            roomlist.Add(room);
        }

    }

    

}
