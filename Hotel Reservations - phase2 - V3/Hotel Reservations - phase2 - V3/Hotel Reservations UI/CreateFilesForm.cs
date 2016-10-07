using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Reservations_BI;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Xsl;
using System.Diagnostics;
using System.Xml;
using System.Xml.XPath;
/*
* COP 4814 - Kirp irvine - TTH 1700-1815
* 
* Assignment 2 - Hotel Reservation(phase I): Displaying a Hotel List
* Write a C# program that uses serialization to create two XML files.
* The first named hotels.xml, will contain information about 10 imaginary hotels in a single geographical area.
* The second file named roominventory.xml file, containing available room inventories for the same 10 hotels,
* accross a range of 30 days.
* 
* Due date:10/09/2016
* 
* Team Members/Authors: Winkens Henri, Anthony Marrero, and Jordan Rodriguez
*/



namespace Hotel_Reservations_UI

{
    public partial class CreateFilesForm : Form
    {
        HotelFactory hotelfactory = new HotelFactory();

        List<Hotel> hotelList;
        List<InventoryType> RoomInventory;
        List<RoomType> roomtypes;
        HotelListItem hotellistitem = new HotelListItem();
        List<HotelListItem> HotelListItems;
        const string outfile = "style.html";
        //StreamWriter sw;
        //XmlSerializer serial;


        const string HOTEL_FILENAME = @"..\..\hotels2.xml";
        const string ROOMINVENTORY_FILENAME = @"..\..\roominventory2.xml";
        const string ROOMTYPES_FILENAME = @"..\..\roomtypes.xml";
        const string HOTELLISTITEM_FILENAME = @"..\..\hotelListItem.xml";
        const string XSLT_FILE = @"..\..\XSLTFile1.xslt";

        public CreateFilesForm()
        {
            InitializeComponent();
        }

        private void CreateFilesForm_Load(object sender, EventArgs e)
        {

        }

        private void mnuCreateHotel_Click(object sender, EventArgs e)
        {
            hotelList = new HotelFactory().CreateNewHotel();
            hotelfactory.HotelXMLSerializer(hotelList, HOTEL_FILENAME);
        }

        private void mnuCreateRoomInventory_Click(object sender, EventArgs e)
        {
            hotelList = new HotelFactory().CreateNewHotel();

            DateTime startDate = new DateTime(2016, 09, 01);
            DateTime endDate = new DateTime(2016, 09, 30);

            RoomInventory = new InventoryType().GetRoomInventory(hotelList, startDate, endDate);

            hotelfactory.HotelXMLSerializer(RoomInventory, ROOMINVENTORY_FILENAME);
        }

        private void mnuDispHotels_Click(object sender, EventArgs e)
        {
            BrowserForm frm = new BrowserForm();
            frm.URL = "hotels2.xml";
            frm.ShowDialog();
        }

        private void mnuDispInventory_Click(object sender, EventArgs e)
        {
            BrowserForm frm = new BrowserForm();
            frm.URL = "roominventory2.xml";
            frm.ShowDialog();
        }

        private void btnLoadHotel_Click(object sender, EventArgs e)
        {
            hotelList = new List<Hotel>();
            hotelList = hotelfactory.HotelXMLDeserializer(hotelList, HOTEL_FILENAME);

            roomtypes = new List<RoomType>();
            roomtypes = hotelfactory.roomDeserialer(roomtypes, ROOMTYPES_FILENAME);
        }

        private void btnCreateHotelList_Click(object sender, EventArgs e)
        {
            HotelListItems = new HotelFactory().GetListOfHotels(roomtypes, hotelList);
            hotelfactory.HotelListItemXMLSerializer(HotelListItems, HOTELLISTITEM_FILENAME);

            BrowserForm frm = new BrowserForm();
            //Transforms the xml file into a Stylesheet
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(XSLT_FILE);
            xslt.Transform(HOTELLISTITEM_FILENAME, outfile);
            //frm.URL = HOTELLISTITEM_FILENAME;
            //frm.ShowDialog();




            Process.Start(outfile);

            //BrowserForm frm = new BrowserForm();
            //frm.URL = "hotelListItem.xml";
            //frm.ShowDialog();


        }


    }
}
