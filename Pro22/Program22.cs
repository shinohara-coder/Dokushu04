using static System.Console;

namespace Pro22
{
    internal class IteratorBasic
    {
        static void Main(string[] args)
        {
            var file = new FileInfo(@"C:\data\sample.txt");

            WriteLine(file.Exists);
            WriteLine(file.Name);
            WriteLine(file.DirectoryName);
            WriteLine(file.IsReadOnly);
            WriteLine(file.LastAccessTime);
            WriteLine(file.LastWriteTime);
            WriteLine(file.Length);

            var file2 = file.CopyTo(@"C:\data\sample_copy.txt", true);

            file2.MoveTo(@"C:\data\SelfCSharp\sample_copy.txt");

            file2.MoveTo(@"C:\data\SelfCSharp\sample_renamed.txt");

            file2.Delete();
        }
    }
}
