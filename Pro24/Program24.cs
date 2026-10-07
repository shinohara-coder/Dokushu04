using static System.Console;

namespace Pro24
{
    internal class PassOut
    {
        static void Main(string[] args)
        {
            var filePath = @"C:\data\sample.txt";
            
            WriteLine(File.Exists(filePath));
            WriteLine(File.GetLastAccessTime(filePath));
            WriteLine(File.GetLastWriteTime(filePath));

            File.Copy(filePath, @"C:\data\sample_copy.txt", true);

            File.Move(@"C:\data\sample_copy.txt", @"C:\data\SelfCSharp\sample_copy.txt");

            File.Move(@"C:\data\SelfCSharp\sample_copy.txt", @"C:\data\SelfCSharp\sample_renamed.txt");

            File.Delete(@"C:\data\SelfCSharp\sample_renamed.txt");
        }
       
    }
}
