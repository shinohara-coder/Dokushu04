using System.Globalization;
using static System.Console;


namespace Pro25
{
    internal partial class MyPartialMethod
    {
        static void Main(string[] args)
        {
            var folderPath = @"C:\data\SelfCSharp";
            WriteLine(Directory.Exists(folderPath));
            WriteLine(Directory.GetParent(folderPath));
            WriteLine(Directory.GetDirectoryRoot(folderPath));
            WriteLine(Directory.GetCreationTime(folderPath));
            WriteLine(Directory.GetLastAccessTime(folderPath));
            WriteLine(Directory.GetLastWriteTime(folderPath));

            var dirs = Directory.GetFiles(folderPath);
            foreach (var d in dirs)
            {
                WriteLine(d);
            }

            Directory.CreateDirectory(@"C:\data\smp");

            Directory.Move(@"C:\data\smp", @"C:\data\test");

            Directory.Move(@"C:\data\test", @"C:\data\SelfCSharp\test");

            Directory.Delete(@"C:\data\SelfCSharp\test");
        }
    }
}
