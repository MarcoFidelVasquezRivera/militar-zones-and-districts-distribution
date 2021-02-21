using System;
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

            string[] headers = line.Split(',');
            GenerateTable(headers);

            line = reader.ReadLine();

            while (line!=null && !line.Equals(""))
            {
                line = line.Trim(new Char[] {'(',')','"',});
                Console.WriteLine(line);
                string[] info = line.Split(',');
                
                int zoneNumber = System.Convert.ToInt32(info[0]);
                string zoneDistrict = info[1];
                string address = info[2];
                string city = info[3];
                string phoneNumber = info[4];
                double latitude = System.Convert.ToDouble(info[5]);
                double longitude = System.Convert.ToDouble(info[6]);

                Console.WriteLine(zoneNumber+ "," + zoneDistrict + "," + address + "," + city + "," + phoneNumber +","+latitude+","+longitude);
                MilitarZoneOrDistrict toAdd = new MilitarZoneOrDistrict(zoneNumber, zoneDistrict, address, city, phoneNumber, latitude, longitude);

                militarZones.Add(toAdd);
                line = reader.ReadLine();
            }
        }

        public void GenerateTable(String[] headers)
        {
            foreach (string head in headers)
            {
                this.dataTable.Columns.Add(head);
            }
        }

        public void FilterByInterval(int LowerInterval, int HigherInterval) 
        {
            dataTable.Rows.Clear();
            List<MilitarZoneOrDistrict> passedFilter = new List<MilitarZoneOrDistrict>();
            foreach (MilitarZoneOrDistrict mz in militarZones)
            {
                if (mz.GetZoneNumber() >= LowerInterval && mz.GetZoneNumber() <= HigherInterval) 
                {
                    passedFilter.Add(mz);                
                
                }
            }
            dataTable.Rows.Add(passedFilter);
        }



    }
}
