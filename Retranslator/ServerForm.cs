using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Retranslator
{
    public partial class ServerForm : Form
    {
        private Server server;

        public ServerForm()
        {
            InitializeComponent();

            server = new Server();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            const string stationIdColumn = "ID";
            const string stationNameColumn = "StationName";
            const string stationFrequencyColumn = "Frequency";
            const string stationModulationColumn = "Modulation";
            const string stationGroupSpeedColumn = "GroupSpeed";

            server.ClearStantionList();

            var stations = server.OrderSchemePairs.SelectMany(pair =>
                   new[] { pair.Station1, pair.Station2 })
                   .Where(s => s != null).ToList();

            foreach (var row in this.dataGridView1.Rows.Cast<DataGridViewRow>())
            {
                if(!stations.Any(s=>s.Id == (string)row.Cells[stationIdColumn].Value)) {
                    this.dataGridView1.Rows.Remove(row);
                }
            }

            foreach (var station in stations)
            {
                var row = this.dataGridView1.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => r.Cells[stationIdColumn].Value == station.Id);
                if (row == null)
                {
                    int index = this.dataGridView1.Rows.Add();
                    row = this.dataGridView1.Rows[index];
                }

                row.Cells[stationIdColumn].Value = station.Id;
                row.Cells[stationNameColumn].Value = "Name";
                row.Cells[stationFrequencyColumn].Value = station.Signal == null 
                    ? "no signal" 
                    : station.Signal.Frequency.ToString();
                row.Cells[stationModulationColumn].Value = station.Signal == null
                    ? "no signal"
                    : station.Signal.Modulation.ToString();
                row.Cells[stationGroupSpeedColumn].Value = station.Signal == null
                    ? "no signal"
                    : station.Signal.GroupSpeed.ToString();
            }
        }
    }
}
