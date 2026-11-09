global using static System.Console;

using SelfCSharp.Chap09.Priority1;
//using MyUtil = SelfCSharp.Chap09.Priority2.MyUtil;
//using Microsoft.Scripting.Hosting.Shell;

namespace SelfCSharp.Chap09.Priority1
{
    internal class MyUtil
    {
        public static void Run()
        {
            WriteLine("Priority1名前空間");
        }
    }
}

namespace SelfCSharp.Chap09.Priority2
{
    internal class MyUtil
    {
        public static void Run()
        {
            WriteLine("Priority2名前空間");
        }
    }
}

namespace SelfCSharp.Chap09.Priority3
{
    internal class MyUtil
    {
        public static void Run()
        {
            WriteLine("Priority3名前空間");
        }
    }
}

//internal class MyUtil
//{
//    public static void Run()
//    {
//        WriteLine("グローバル名前空間");
//    }
//}

namespace Pro18
{
    //using SelfCSharp.Chap09.Priority3;

    //internal class MyUtil
    //{
    //    public static void Run()
    //    {
    //        WriteLine("現在の名前空間");
    //    }
    //}
    
    internal class NameOfNull
    {
        static void Main(string[] args)
        {
            MyUtil.Run();
        }
    }
}

