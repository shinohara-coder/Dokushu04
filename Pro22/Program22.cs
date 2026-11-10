global using static System.Console;

namespace Pro22
{
    internal class IteratorBasic
    {
        static void Main(string[] args)
        {
            try
            {
                var f = new StreamReader(@"C:\nothing.cs");
            }
            catch (FileNotFoundException ex) when (ex.Message.Contains(".dat"))
            {
                WriteLine("存在しない.datファイルが指定されました。");
            }
            catch (FileNotFoundException)
            {
                WriteLine("存在しないファイルが指定されました。");
            }
        }
    }
}
