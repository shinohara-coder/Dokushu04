internal class Util
{
    public static void Run()
    {
        Console.WriteLine("Util is running.");
    }
}

namespace SelfCSharp.Chap09.Util
//namespace SelfCSharp.Chap09
{
    internal class NamespaceGlobal
    {
        static void Main(string[] args)
        {
            //Util.Run();
            global::Util.Run();
        }
    }
}

