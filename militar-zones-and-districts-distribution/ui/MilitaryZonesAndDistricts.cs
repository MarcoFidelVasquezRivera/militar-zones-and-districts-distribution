using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using militar_zones_and_districts_distribution.model;

namespace militar_zones_and_districts_distribution
{
    public partial class Form1 : Form
    {

        private MilitarZonesManager manager;
        enum Type {NUMERIC, CATEGORIC, CHAIN}
        private Dictionary<string, Type> clasification;


        public Form1()
        {
            InitializeComponent();
            
            manager = new MilitarZonesManager();
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
    }
}
