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
        internal double Latitude;
        internal double Longitude;

        //internal Coodinates() { }

        public override string ToString()
        {
            return $"緯度: {this.Latitude} / 経度: {this.Longitude}";
        }
    }
    internal class PassOUt
    {
        
        static void Main(string[] args)
        {
            var c = new Coodinates();
            c.Latitude = 35.681167;
            c.Longitude = 139.767052;
            Console.WriteLine(c);
        }
    }
}
