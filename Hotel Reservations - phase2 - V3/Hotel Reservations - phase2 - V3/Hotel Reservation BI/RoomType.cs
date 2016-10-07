using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Hotel_Reservations_BI
{
    public class RoomType
    {

        public string id { get; set; }

        public string  name { get; set; }


        public RoomType(){ }

        public RoomType(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public string GetRoomName(List<RoomType> rtl, string ID)
        {
            string RoomName;
         foreach(RoomType rt in rtl)
            {
                if (rt.id == ID)
                   return RoomName = rt.name;
            }
            return "No room name matching this id";
        }




    }
}
