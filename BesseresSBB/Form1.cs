using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BesseresSBB
{
    public partial class Form1 : Form
    {
        private ITransport transport;
        public Form1()
        {
            InitializeComponent();
        }

        private void switchStations_Click(object sender, EventArgs e)
        {
            string nach = txtNach.Text;
            string von = txtVon.Text;

            txtVon.Text = nach;
            txtNach.Text = von;
        }

        

        private void search_Click(object sender, EventArgs e)
        {
            var transport = new Transport();
            var connectionList = transport.GetConnections(txtVon.Text, txtNach.Text);

            foreach(var connection in connectionList.ConnectionList) { 
            
               
                ConnectionPoint from = connection.From;
                ConnectionPoint to = connection.To;

                ListViewItem itemVerbindung = new ListViewItem(from.Station.Name);
                

                var abfahrt = DateTime.Parse(connection.From.Departure);
                var ankunft = DateTime.Parse(connection.To.Arrival);
                

                itemVerbindung.SubItems.Add(abfahrt.ToString("hh.mm"));
                itemVerbindung.SubItems.Add(connection.To.Station.Name);
                itemVerbindung.SubItems.Add(ankunft.ToString("hh.mm"));
                itemVerbindung.SubItems.Add(KürzungDauer(connection.Duration));

                livVerbindungen.Items.AddRange(new ListViewItem[] { itemVerbindung });

  
            }
        }
        #region Kürzung
        /*Kürzungen
        private String KürzungAbfahrt(ConnectionPoint from)
        {
            int startIndex = 11;
            int length = 5;
            String Abfahrt = from.Departure.Substring(startIndex, length);
            return Abfahrt;
        }

        private String KürzungAnkunft(ConnectionPoint To)
        {
            int startIndex = 11;
            int length = 5;
            String Ankunft = To.Arrival.Substring(startIndex, length);
            return Ankunft;
        }
        */

        private String KürzungDauer(string result)
        {
            String Dauer = result.Substring(3, 5);
            return Dauer;
        }
#endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            livVerbindungen.Columns.Add("Von", 120);
            livVerbindungen.Columns.Add("Abfahrt", 120);
            livVerbindungen.Columns.Add("Nach", 120);
            livVerbindungen.Columns.Add("Ankunft", 120);
            livVerbindungen.Columns.Add("Dauer", 120);

            livStationBoard.Columns.Add("Zeit", 70);
            livStationBoard.Columns.Add("Nach", 400);
            livStationBoard.Columns.Add("Bus", 70);


        }

        private void btnFahrplanSuchen_Click(object sender, EventArgs e)
        {
            var transport = new Transport();
            var stationList = transport.GetStations(txtStation.Text);

            var station = stationList.StationList[0];
            string id = station.Id;

            var stationboard = transport.GetStationBoard(txtStation.Text, id);
            foreach ( var stationlist in stationboard.Entries)
            {
                DateTime Abfahrt = DateTime.Parse(stationlist.Stop.Departure.ToString());
                ListViewItem itemStation = new ListViewItem(Abfahrt.ToString("hh.mm"));
                itemStation.SubItems.Add(stationlist.To);
                itemStation.SubItems.Add(stationlist.Number);

                livStationBoard.Items.AddRange(new ListViewItem[] { itemStation });
            }
        }
    }
}
