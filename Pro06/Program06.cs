using Pro06.Extension;
using static System.Console;

namespace Pro06
{
    internal struct Coodinates
    {
        //private double Latitude = default;
        //private double longitude = default;

        public double Latitude { private set; get; }
        public double Longitude { private set; get; }


        public Coodinates() { }

        public Coodinates(double lat, double longt)
        {
            this.Latitude = lat;
            //this.Longitude = longt;
        }

        public override string ToString()
        {
            return $"緯度：{this.Latitude} / 経度：{this.Longitude}";
        }
    }

    internal class AsyncStream
    {
        static void Main(string[] args)
        {
            //var c = new Coodinates(35.681167, 139.767052);
            Coodinates c = new Coodinates(35.68117, 139.767052);
            //c.Latitude = 35.681167;
            //c.Longitude = 139.767052;

            //var c = default(Coodinates);
            WriteLine(c.Latitude);
        }
    }
}
