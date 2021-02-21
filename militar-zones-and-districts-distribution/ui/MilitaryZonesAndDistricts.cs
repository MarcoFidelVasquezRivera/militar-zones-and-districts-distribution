using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using militar_zones_and_districts_distribution.model;

namespace militar_zones_and_districts_distribution
{
    public partial class Form1 : Form
    {

        private MilitarZonesManager manager;
        enum Type {NUMERIC, CATEGORIC, CHAIN}
        private Dictionary<string, Type> clasification;

        private GMapOverlay markers;

        public Form1()
        {
            InitializeComponent();
            
            manager = new MilitarZonesManager();
            markers = new GMapOverlay("markers");
            clasification = new Dictionary<string, Type>()
            {
                {"ZONA", Type.NUMERIC},
                {"ZONA-DIM", Type.CHAIN },
                {"DIRECCION",Type.CHAIN},
                {"CIUDAD", Type.CATEGORIC},
                {"TELEFONO", Type.CHAIN},
                {"LATITUD", Type.NUMERIC},
                {"LONGITUD", Type.NUMERIC}
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FilterByCity.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "csv files (*.csv)|*.csv";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;

                manager.LoadZones(selectedFileName);
                manager.FilterByInterval("ZONA", int.MinValue, int.MaxValue);
                zonesTable.DataSource = manager.getTable();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Type type = clasification[Filters.Text];
            switch (type)
            {
                case Type.CATEGORIC:
                    manager.FilterByCategory(FilterByCity.Text);
                    zonesTable.DataSource = manager.getTable();
                    break;

                case Type.CHAIN:
                    manager.FilterByChain(Filters.Text, textBox1.Text);
                    zonesTable.DataSource = manager.getTable();
                    break;

                case Type.NUMERIC:
                    double minimum = System.Convert.ToDouble(textBox1.Text, System.Globalization.CultureInfo.InvariantCulture);
                    double maximum = System.Convert.ToDouble(textBox2.Text, System.Globalization.CultureInfo.InvariantCulture);
                    manager.FilterByInterval(Filters.Text, minimum, maximum);
                    break;

            }

            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void Filters_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterByCity.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            Type type = clasification[Filters.Text];
            switch (type) 
            {
                case Type.CATEGORIC:
                    FilterByCity.Visible = true;
                break;

                case Type.CHAIN:
                    textBox1.Visible = true;
                    textBox1.Text = "chain";
                    break;

                case Type.NUMERIC:
                    textBox1.Text = "minimum";
                    textBox2.Text = "maximum";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                break;

            }
        }

        private void chartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (chartType.Text)
            {
                case "Barras":
                    drawLineChart();
                    break;

                case "Pastel":
                    drawPieChart();
                    break;

                case "Puntos":
                    drawPointChart();
                break;

            }
        }


        private void drawPieChart() 
        {
            //reset your chart series and legends
            chart1.Series.Clear();
            chart1.Legends.Clear();

            //Add a new chart-series
            string seriesName = "Zonas por ciudad";
            chart1.Series.Add(seriesName);
            chart1.Series[seriesName].IsValueShownAsLabel = true;

            //Add a new Legend(if needed) and do some formating
            chart1.Legends.Add("Legend1");
            chart1.Legends[0].LegendStyle = LegendStyle.Table;
            chart1.Legends[0].Alignment = StringAlignment.Center;
            chart1.Legends[0].Title = "Ciudades";
            chart1.Legends[0].BorderColor = Color.Black;

            //set the chart-type to "Pie"
            chart1.Series[seriesName].ChartType = SeriesChartType.Pie;

            Dictionary<String, int> toAdd = manager.GetMilitarZoneOrDistricts();
            
            //Add some datapoints so the series. in this case you can pass the values to this method
            foreach(KeyValuePair<string,int> val in toAdd)
            {
                chart1.Series[seriesName].Points.AddXY(val.Key, val.Value);
    
            }
        }


        private void drawLineChart()
        {
            //reset your chart series and legends
            chart1.Series.Clear();
            chart1.Legends.Clear();

            //Add a new chart-series
            string seriesName = "Zonas por ciudad";
            chart1.Series.Add(seriesName);
            chart1.Series[seriesName].IsValueShownAsLabel = true;

            //set the chart-type to "Bar"
            chart1.Series[seriesName].ChartType = SeriesChartType.Column;

            Dictionary<String, int> toAdd = manager.GetMilitarZoneOrDistricts();
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            //Add some datapoints so the series. in this case you can pass the values to this method
            foreach (KeyValuePair<string, int> val in toAdd)
            {
                chart1.Series[seriesName].Points.AddXY(val.Key, val.Value);

            }
        }

        private void drawPointChart()
        {
            //reset your chart series and legends
            chart1.Series.Clear();
            chart1.Legends.Clear();

            //Add a new chart-series
            string seriesName = "Zonas por ciudad";
            chart1.Series.Add(seriesName);
            chart1.Series[seriesName].IsValueShownAsLabel = true;

            //set the chart-type to "Bar"
            chart1.Series[seriesName].ChartType = SeriesChartType.Point;

            Dictionary<String, int> toAdd = manager.GetMilitarZoneOrDistricts();
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            //Add some datapoints so the series. in this case you can pass the values to this method
            foreach (KeyValuePair<string, int> val in toAdd)
            {
                chart1.Series[seriesName].Points.AddXY(val.Key, val.Value);

            }
        }

        private void gMap_Load(object sender, EventArgs e)
        {
            gMap.MapProvider = GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMap.Position = new PointLatLng(4.6482837, -74.2478938); //coordenadas de bogotá
            gMap.ShowCenter = false;

            gMap.Overlays.Add(markers);

            ShowMarkers();
        }

        private void ShowMarkers()
        {
            List<MilitarZoneOrDistrict> militarZones = manager.GetListOfMilitarZones();

            foreach (MilitarZoneOrDistrict zone in militarZones)
            {
                PointLatLng newMarker = new PointLatLng(zone.GetLatitude(), zone.GetLongitude());

                GMapMarker marker = new GMarkerGoogle(newMarker, GMarkerGoogleType.red_dot);
                marker.ToolTipText = zone.GetZoneDistrict() + "\n" + zone.GetLatitude() + "\n" + zone.GetLongitude();
                markers.Markers.Add(marker);
            }

        }
    }
}
