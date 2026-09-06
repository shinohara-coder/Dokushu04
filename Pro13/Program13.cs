using static System.Console;

namespace Pro13
{
    struct Coordinates
    {
        public double Latitude;
        public double Longitude;

        public override string ToString()
        {
            return $"緯度：{this.Latitude}／経度：{this.Longitude}";
        }
    }
    
    internal class AsyncReurn
    {   
        static void Main(string[] args)
        {
            var c = new Coordinates();
            c.Latitude = 36.41703;
            c.Longitude = 139.81664;
            WriteLine(c);
        }
    }
}
