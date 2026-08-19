//#define DEBUG
namespace Pro07
{
    internal class Figure
    {
        //public static double Pi = 3.14;
        private static double Pi = 3.14;
        public static void GetCircleArea(double r)
        {
            Console.WriteLine($"円の面積は{r * r * Pi}");
        }

        public static void GetTriangleArea(double width, double height)
        {
            Console.WriteLine($"三角形の面積は{width * height / 2}");
        }
    }
    
    internal class AsyncBasic
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Figure.Pi);
            Figure.GetCircleArea(3);
            Figure.GetTriangleArea(5, 15);
        }
    }
}
