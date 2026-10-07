using static System.Console;

namespace Pro23
{
    internal class NamespaceGlobal
    {
        static void Main(string[] args)
        {
            var dir = new DirectoryInfo(@"C:\data\SelfCSharp");
            WriteLine(dir.Exists);
            WriteLine(dir.Parent);
            WriteLine(dir.Root);
            WriteLine(dir.CreationTime);
            WriteLine(dir.LastAccessTime);
            WriteLine(dir.LastWriteTime);

            var dirs = dir.GetFiles();
            //var dirs = dir.GetDirectories("Chap*");
            //var dirs = dir.GetDirectories("*", SearchOption.AllDirectories);
            //var dirs = dir.GetFiles();

            foreach (var d in dirs)
            {
                WriteLine(d.FullName);
            }

            var dir2 = new DirectoryInfo(@"C:\data\smp");
            dir2.Create();

            dir2.MoveTo(@"C:\data\test");

            dir2.MoveTo(@"C:\data\SelfCSharp\test");

            dir2.CreateSubdirectory("sub");

            dir2.Delete(true);
        }
    }
}

