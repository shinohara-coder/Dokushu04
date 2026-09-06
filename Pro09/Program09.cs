using static System.Console;

namespace Pro08
{
    internal class MySingleton
    {   
        static void Main(string[] args)
        {
            try
            {
                var f = new StreamReader(@"C:\nothing.dat");
            }
            catch (FileNotFoundException ex) when (ex.Message.Contains(".dat") || ex.Message.Contains(".txt"))
            {
                WriteLine("存在しないファイル.datまたは.txtが指定されました。");
                WriteLine(ex.Message);
            }
            catch (FileNotFoundException)
            {
                WriteLine("存在しないファイルが指定されました。");
            }
        }
    }
}

