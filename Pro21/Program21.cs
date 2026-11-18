global using static System.Console;

namespace Pro21
{
    internal class LambdaMember
    {
        static void Main(string[] args)
        {
            var data = new[] { "C#", "Java", "Python" };
            Array.Resize(ref data, 5);
            data[3] = "C++";
            data[4] = "Ruby";
            foreach(var str in data)
            {
                WriteLine(str);
            }
        }
    }
}
