using Pro06.Extension;
using static System.Console;

namespace Pro06
{
    internal struct Coodinates
    {
        private double Latitude = default;
        private double longtitude = default;

        public Coodinates() { }

        public Coodinates(double lat, double longt)
        {
            this.Latitude = lat;
            this.longtitude = longt;
        }

        public override string ToString()
        {
            return $"緯度：{this.Latitude} / 経度：{this.longtitude}";
        }
    }

    internal class AsyncStream
    {
        static void Main(string[] args)
        {
            var c = new Coodinates(35.681167, 139.767052);
            WriteLine(c);
        }
    }
}
