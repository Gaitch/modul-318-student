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
    public partial class frmFahrplanApp : Form
    {
        private ITransport transport;
        private String input;
        private bool needAutoCompleteUpdate;
        public frmFahrplanApp()
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
            livVerbindungen.Items.Clear();
            var transport = new Transport();
            var connectionList = transport.GetConnections(txtVon.Text, txtNach.Text);

            foreach (var connection in connectionList.ConnectionList)
            {


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

                input = txtVon.Text;

                var stations = transport.GetStations(input);

                foreach (Station stationName in stations.StationList)
                {
                    txtVon.AutoCompleteCustomSource.Add(stationName.Name);
                }
                this.txtVon.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.txtVon.AutoCompleteSource = AutoCompleteSource.CustomSource;

            }
        }

        
        private String KürzungDauer(string result)
        {
            String Dauer = result.Substring(3, 5);
            return Dauer;
        }
        
        private void frmFahrplanApp_Load(object sender, EventArgs e)
        {
            livVerbindungen.Columns.Add("Von", 150);
            livVerbindungen.Columns.Add("Abfahrt", 75);
            livVerbindungen.Columns.Add("Nach", 150);
            livVerbindungen.Columns.Add("Ankunft", 120);
            livVerbindungen.Columns.Add("Dauer", 75);

            livStationBoard.Columns.Add("Zeit", 70);
            livStationBoard.Columns.Add("Nach", 400);
            livStationBoard.Columns.Add("Bus", 70);

            this.txtVon.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txtVon.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }


        private void btnFahrplanSuchen_Click(object sender, EventArgs e)
        {
            var transport = new Transport();
            var stationList = transport.GetStations(txtStation.Text);

            var station = stationList.StationList[0];
            string id = station.Id;

            var stationboard = transport.GetStationBoard(txtStation.Text, id);
            foreach (var stationlist in stationboard.Entries)
            {
                DateTime Abfahrt = DateTime.Parse(stationlist.Stop.Departure.ToString());
                ListViewItem itemStation = new ListViewItem(Abfahrt.ToString("hh.mm"));
                itemStation.SubItems.Add(stationlist.To);
                itemStation.SubItems.Add(stationlist.Number);

                livStationBoard.Items.AddRange(new ListViewItem[] { itemStation });
            }
        }

        private void Mail(string startStation, string departure, string endStation, string arrival, string duration)
        {
            String url = "mailto:?subject=Öv%20Verbindungen&body=ÖV%20Verbindung%20zwischen%20" +
                            startStation + " - " + endStation + "%0A" +
                            "Abfahrt: " + departure + "%0A" +
                            "Ankunft: " + arrival + "%0A" +
                            "Dauer: " + duration;
            System.Diagnostics.Process.Start(url);
        }

        private void livVerbindungen_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Mail(livVerbindungen.SelectedItems[0].SubItems[0].Text,
            livVerbindungen.SelectedItems[0].SubItems[1].Text,
            livVerbindungen.SelectedItems[0].SubItems[2].Text,
            livVerbindungen.SelectedItems[0].SubItems[3].Text,
            livVerbindungen.SelectedItems[0].SubItems[4].Text
            );

        }

        private void tbVon_TextChanged(object sender, EventArgs e)
        {

 
        
        }
    }
}
