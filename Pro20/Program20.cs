global using static System.Console;

namespace Pro20
{
    internal class ModuleInit
    {
        static void Main(string[] args)
        {
            try
            {
                using (var sr = new StreamReader(@"C:\nothing.dat"))
                {
                    WriteLine(sr.ReadToEnd());
                }
            }
            catch (FileNotFoundException ex)
            {
                WriteLine("ファイルが見つかりませんでした。");
                WriteLine(ex.StackTrace);
            }
        }
    }
}
