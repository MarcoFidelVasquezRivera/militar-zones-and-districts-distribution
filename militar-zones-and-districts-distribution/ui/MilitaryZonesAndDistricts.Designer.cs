﻿
namespace militar_zones_and_districts_distribution
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chartType = new System.Windows.Forms.ComboBox();
            this.FilterByCity = new System.Windows.Forms.ComboBox();
            this.Filters = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.zonesTable = new System.Windows.Forms.DataGridView();
            this.Filter = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.filterMap = new System.Windows.Forms.ComboBox();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonesTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1451, 679);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.chartType);
            this.tabPage1.Controls.Add(this.FilterByCity);
            this.tabPage1.Controls.Add(this.Filters);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Controls.Add(this.zonesTable);
            this.tabPage1.Controls.Add(this.Filter);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1443, 653);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tabla";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(369, 585);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(263, 586);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // chartType
            // 
            this.chartType.FormattingEnabled = true;
            this.chartType.Items.AddRange(new object[] {
            "Barras",
            "Pastel",
            "Puntos"});
            this.chartType.Location = new System.Drawing.Point(1100, 582);
            this.chartType.Name = "chartType";
            this.chartType.Size = new System.Drawing.Size(121, 21);
            this.chartType.TabIndex = 5;
            this.chartType.SelectedIndexChanged += new System.EventHandler(this.chartType_SelectedIndexChanged);
            // 
            // FilterByCity
            // 
            this.FilterByCity.FormattingEnabled = true;
            this.FilterByCity.Items.AddRange(new object[] {
            "ARAUCA",
            "ARMENIA",
            "BARBOSA",
            "BARRANCABERMEJA",
            "BARRANQUILLA",
            "BOGOTA",
            "BUCARAMANGA",
            "BUENAVENTURA",
            "BUGA",
            "CAJICA",
            "CALI",
            "CAREPA",
            "CARTAGENA",
            "CARTAGO",
            "CAUCASIA",
            "CHAPARRAL",
            "CHIQUINQUIRA",
            "CUCUTA",
            "FACATATIVA",
            "FLORENCIA",
            "FUSAGASUGA",
            "GIRARDOT",
            "GRANADA",
            "HONDA",
            "IBAGUE",
            "IPIALES",
            "MANIZALES",
            "MEDELLIN",
            "MOCOA",
            "MONTERIA",
            "NEIVA",
            "OCAÑA",
            "PALMIRA",
            "PAMPLONA",
            "PASTO",
            "PEREIRA",
            "PITALITO",
            "POPAYAN",
            "PUERTO BERRRIO",
            "QUIBDO",
            "RIOHACHA",
            "SANTA MARTA",
            "SINCELEJO",
            "SOACHA",
            "SOCORRO",
            "SOGAMOSO",
            "TUNJA",
            "VALLEDUPAR",
            "VILLAVICENCIO",
            "YOPAL"});
            this.FilterByCity.Location = new System.Drawing.Point(136, 585);
            this.FilterByCity.Name = "FilterByCity";
            this.FilterByCity.Size = new System.Drawing.Size(121, 21);
            this.FilterByCity.TabIndex = 4;
            // 
            // Filters
            // 
            this.Filters.FormattingEnabled = true;
            this.Filters.Items.AddRange(new object[] {
            "ZONA",
            "ZONA-DIM",
            "DIRECCION",
            "CIUDAD",
            "TELEFONO",
            "LATITUD",
            "LONGITUD"});
            this.Filters.Location = new System.Drawing.Point(9, 585);
            this.Filters.Name = "Filters";
            this.Filters.Size = new System.Drawing.Size(121, 21);
            this.Filters.TabIndex = 3;
            this.Filters.SelectedIndexChanged += new System.EventHandler(this.Filters_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(816, 6);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chart1.Size = new System.Drawing.Size(621, 544);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // zonesTable
            // 
            this.zonesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zonesTable.Location = new System.Drawing.Point(9, 6);
            this.zonesTable.Name = "zonesTable";
            this.zonesTable.Size = new System.Drawing.Size(801, 544);
            this.zonesTable.TabIndex = 1;
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(480, 582);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(75, 23);
            this.Filter.TabIndex = 0;
            this.Filter.Text = "Filtrar";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.filterMap);
            this.tabPage2.Controls.Add(this.gMap);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1443, 653);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mapa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // filterMap
            // 
            this.filterMap.FormattingEnabled = true;
            this.filterMap.Items.AddRange(new object[] {
            "TODO",
            "ARAUCA",
            "ARMENIA",
            "BARBOSA",
            "BARRANCABERMEJA",
            "BARRANQUILLA",
            "BOGOTA",
            "BUCARAMANGA",
            "BUENAVENTURA",
            "BUGA",
            "CAJICA",
            "CALI",
            "CAREPA",
            "CARTAGENA",
            "CARTAGO",
            "CAUCASIA",
            "CHAPARRAL",
            "CHIQUINQUIRA",
            "CUCUTA",
            "FACATATIVA",
            "FLORENCIA",
            "FUSAGASUGA",
            "GIRARDOT",
            "GRANADA",
            "HONDA",
            "IBAGUE",
            "IPIALES",
            "MANIZALES",
            "MEDELLIN",
            "MOCOA",
            "MONTERIA",
            "NEIVA",
            "OCAÑA",
            "PALMIRA",
            "PAMPLONA",
            "PASTO",
            "PEREIRA",
            "PITALITO",
            "POPAYAN",
            "PUERTO BERRRIO",
            "QUIBDO",
            "RIOHACHA",
            "SANTA MARTA",
            "SINCELEJO",
            "SOACHA",
            "SOCORRO",
            "SOGAMOSO",
            "TUNJA",
            "VALLEDUPAR",
            "VILLAVICENCIO",
            "YOPAL"});
            this.filterMap.Location = new System.Drawing.Point(1111, 49);
            this.filterMap.Name = "filterMap";
            this.filterMap.Size = new System.Drawing.Size(121, 21);
            this.filterMap.TabIndex = 1;
            this.filterMap.SelectedIndexChanged += new System.EventHandler(this.filterMap_SelectedIndexChanged);
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemmory = 5;
            this.gMap.Location = new System.Drawing.Point(9, 6);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 20;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(1040, 566);
            this.gMap.TabIndex = 0;
            this.gMap.Zoom = 5D;
            this.gMap.Load += new System.EventHandler(this.gMap_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 689);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Military Zone Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonesTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.ComboBox filterMap;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.ComboBox Filters;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView zonesTable;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox chartType;
        private System.Windows.Forms.ComboBox FilterByCity;
    }
}

