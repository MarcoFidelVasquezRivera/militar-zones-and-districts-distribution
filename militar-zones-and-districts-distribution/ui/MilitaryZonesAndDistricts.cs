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
        public Form1()
        {
            InitializeComponent();
            manager = new MilitarZonesManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "csv files (*.csv)|*.csv";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;

                manager.LoadZones(selectedFileName);
                manager.FilterByInterval("Numero de zona",int.MinValue,int.MaxValue);
                zonesTable.DataSource = manager.getTable();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
