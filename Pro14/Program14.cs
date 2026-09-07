using static System.Console;

namespace Pro14
{
    struct Coordinates
    {
        public double Latitude;
        public double Longitude;

        public Coordinates(double latitude, double longtitude)
        {
            this.Latitude = latitude;
            //this.Longitude = longtitude;
        }

        public override string ToString()
        {
            return $"緯度：{this.Latitude}／経度：{this.Longitude}";
        }
    }
    
    internal class DelegeteNoUse
    {
       static void Main(string[] args)
        {
            var c = new Coordinates(35.681167, 139.767052);
            WriteLine(c);
        }
    }
}
