using System.Text.RegularExpressions;

namespace Pro08
{
    internal class MyApp
    {
        public static readonly string Title = "独習C#";
    }
    internal class MySingleton
    {   
        static void Main(string[] args)
        {
            Console.WriteLine(MyApp.Title);
            //MyApp.Title = "独習C++";
        }
    }
}

