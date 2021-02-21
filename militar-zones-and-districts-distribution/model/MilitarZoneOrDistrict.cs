using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace militar_zones_and_districts_distribution.model
{
    public class MilitarZoneOrDistrict
    {
        private int zoneNumber;
        private string zoneDistrict;
        private string address;
        private string city;
        private string phoneNumber;
        private double latitude;
        private double longitude;

        public MilitarZoneOrDistrict(int zoneNumber, string zoneDistrict, string address, string city, string phoneNumber, double latitude, double longitude)
        {
            this.zoneNumber = zoneNumber;
            this.zoneDistrict = zoneDistrict;
            this.address = address;
            this.city = city;
            this.phoneNumber = phoneNumber;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public int GetZoneNumber()
        {
            return this.zoneNumber;
        }

        public string GetZoneDistrict()
        {
            return this.zoneDistrict;
        }

        public string GetAddress()
        {
            return this.address;
        }

        public string GetCity()
        {
            return this.city;
        }

        public string GetphoneNumeer()
        {
            return this.phoneNumber;
        }

        public double GetLatitude()
        {
            return this.latitude;
        }

        public double GetLongitude()
        {
            return this.longitude;
        }

        public void SetZoneNumber(int zoneNumber)
        {
            this.zoneNumber = zoneNumber;
        }

        public void SetZoneDistrict(string zoneDistrict)
        {
            this.zoneDistrict = zoneDistrict;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public void SetCity(string city)
        {
            this.city = city;
        } 

        public void SetPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public void SetLatitude(double latitude)
        {
            this.latitude = latitude;
        }

        public void SetLongitude(double longitude)
        {
            this.longitude = longitude;
        }
    }
}
