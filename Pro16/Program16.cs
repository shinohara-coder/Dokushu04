using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;

namespace Pro16
{
    internal struct Coodinates
    {
        internal double Latitude { get; set; }
        internal double Longitude { get; set; }

        public Coodinates() { }
        internal Coodinates(double lat, double lon) 
        {
            this.Latitude = lat;
            this.Longitude = lon;
        }

        public override string ToString()
        {
            return $"緯度: {this.Latitude} / 経度: {this.Longitude}";
        }
    }
    internal class PassOUt
    {
        
        static void Main(string[] args)
        {
            //var c = new Coodinates(35.681167, 139.767052);
            //var c = new Coodinates
            //{
            //    Latitude = 35.681167,
            //    Longitude = 139.767052
            //};
            var c = new Coodinates();

            //c.Latitude = 35.681167;
            //c.Longitude = 139.767052;
            Console.WriteLine(c);
        }
    }
}
