using System.IO.Pipes;
using System.Runtime.InteropServices;
using static System.Console;

namespace Pro21
{
    internal class LambdaMember
    {
        static void Main(string[] args)
        {
            var filePath = @"C:\Learning_Programming\独習C#\sample\SelfCSharp\data.log";

            using (var reader = new StreamReader(filePath))
            {
                //WriteLine(reader.ReadToEnd());
                while (!reader.EndOfStream)
                {
                    WriteLine(reader.ReadLine());
                }
            }
        }
    }
}
