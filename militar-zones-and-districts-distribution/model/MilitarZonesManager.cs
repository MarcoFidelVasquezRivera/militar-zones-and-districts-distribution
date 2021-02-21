﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace militar_zones_and_districts_distribution.model
{
    public class MilitarZonesManager
    {
        private List<MilitarZoneOrDistrict> militarZones;
        private DataTable dataTable;


        public MilitarZonesManager()
        {
            militarZones = new List<MilitarZoneOrDistrict>();
            dataTable = new DataTable();
        }

        public void LoadZones(String path)
        {
            var reader = new StreamReader(File.OpenRead(@path));
            string line = reader.ReadLine();

            string[] headers = line.Split(';',',');
            GenerateTable();

            line = reader.ReadLine();

            while (line!=null && !line.Equals(""))
            {

                Console.WriteLine(line);
                string[] info = line.Split(',',';');
                
                int zoneNumber = System.Convert.ToInt32(info[0]);
                string zoneDistrict = info[1];
                string address = info[2];
                string city = info[3];
                string phoneNumber = info[4];
                double latitude = System.Convert.ToDouble(info[5].TrimStart('"','('), System.Globalization.CultureInfo.InvariantCulture);
                double longitude = System.Convert.ToDouble(info[6].TrimEnd('"', ')'), System.Globalization.CultureInfo.InvariantCulture);

                Console.WriteLine(zoneNumber+ "," + zoneDistrict + "," + address + "," + city + "," + phoneNumber +","+latitude+","+longitude);
                MilitarZoneOrDistrict toAdd = new MilitarZoneOrDistrict(zoneNumber, zoneDistrict, address, city, phoneNumber, latitude, longitude);

                militarZones.Add(toAdd);
                line = reader.ReadLine();
            }
        }

        public void GenerateTable()
        {

            this.dataTable.Columns.Add("ZONA");
            this.dataTable.Columns.Add("ZONA-DIM");
            this.dataTable.Columns.Add("DIRECCION");
            this.dataTable.Columns.Add("CIUDAD");
            this.dataTable.Columns.Add("TELEFONOS");
            this.dataTable.Columns.Add("LATITUD");
            this.dataTable.Columns.Add("LONGITUD");

        }

        public void FilterByInterval(String rowName, int LowerInterval, int HigherInterval) 
        {
            dataTable.Rows.Clear();
            List<MilitarZoneOrDistrict> passedFilter = new List<MilitarZoneOrDistrict>();

            if (rowName.Equals("Numero de zona"))
            {
                foreach (MilitarZoneOrDistrict mz in militarZones)
                {
                    if (mz.GetZoneNumber() >= LowerInterval && mz.GetZoneNumber() <= HigherInterval)
                    {
                        DataRow dr = dataTable.NewRow();

                        dr[0] = mz.GetZoneNumber();
                        dr[1] = mz.GetZoneDistrict();
                        dr[2] = mz.GetAddress();
                        dr[3] = mz.GetCity();
                        dr[4] = mz.GetphoneNumber();
                        dr[5] = mz.GetLatitude();
                        dr[6] = mz.GetLongitude();

                        dataTable.Rows.Add(dr);

                    }
                }
            }
            else if (rowName.Equals("Latitud"))
            {
                foreach (MilitarZoneOrDistrict mz in militarZones)
                {
                    if (mz.GetLatitude() >= LowerInterval && mz.GetLatitude() <= HigherInterval)
                    {
                        passedFilter.Add(mz);
                    }
                }
            }else if(rowName.Equals("Longitud"))
            {
                foreach (MilitarZoneOrDistrict mz in militarZones) 
                {
                    if (mz.GetLongitude() >= LowerInterval && mz.GetLongitude() <= HigherInterval) 
                    {
                        {
                            passedFilter.Add(mz);
                        }
                    }
                }
            }

            dataTable.Rows.Add(passedFilter);
        }

        public void FilterByChain(String rowName, String chain)
        {
            dataTable.Rows.Clear();               
            List<MilitarZoneOrDistrict> passedFilter = new List<MilitarZoneOrDistrict>();
            if (rowName.Equals("Zona/Distrito")) {
                foreach (MilitarZoneOrDistrict mz in militarZones)
                {
                    if (mz.GetZoneDistrict().ToUpper().Contains(chain.ToUpper())) 
                    {
                        /*
                        Municipio toAdd = new Municipio(data[1], data[3], data[4]);
                        Departamentos[data[0]].Municipios.Add(toAdd);

                        //here the data is loaded to the datatable
                        DataRow dr = DataTable.NewRow();
                        int columnIndex = 0;
                        foreach (string headerWord in headers)
                        {
                            dr[headerWord] = data[columnIndex++];
                        }
                        
                        */
                        DataRow dr = dataTable.NewRow();

                        dr[0] = mz.GetZoneNumber();
                        dr[1] = mz.GetZoneDistrict();
                        dr[2] = mz.GetAddress();
                        dr[3] = mz.GetCity();
                        dr[4] = mz.GetphoneNumber();
                        dr[5] = mz.GetLatitude();
                        dr[6] = mz.GetLongitude();

                        dataTable.Rows.Add(dr);
                        //passedFilter.Add(mz);

                    }
                }

            }else if (rowName.Equals("Direccion"))
            {
                foreach (MilitarZoneOrDistrict mz in militarZones)
                {
                    if (mz.GetAddress().ToUpper().Contains(chain.ToUpper()))
                    {
                        passedFilter.Add(mz);

                    }
                }
            }
            else if (rowName.Equals("Telefono"))
            {
                foreach (MilitarZoneOrDistrict mz in militarZones)
                {
                    if (mz.GetphoneNumber().ToUpper().Contains(chain.ToUpper()))
                    {
                        passedFilter.Add(mz);

                    }
                }
            }

            dataTable.Rows.Add(passedFilter);
        }

        public void FilterByCategory(String category)
        {
            dataTable.Rows.Clear();
            List<MilitarZoneOrDistrict> passedFilter = new List<MilitarZoneOrDistrict>();
                foreach (MilitarZoneOrDistrict mz in militarZones)
                {
                    if (mz.GetCity().ToUpper().Equals(category.ToUpper()))
                    {
                        passedFilter.Add(mz);
                    }
                           
                }
            dataTable.Rows.Add(passedFilter);
        }   

        public DataTable getTable()
        {
            return dataTable;
        }
    }
}
