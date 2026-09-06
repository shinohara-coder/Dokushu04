using static System.Console;

namespace Pro07
{    
    internal class AsyncBasic
    {
        static void Main(string[] args)
        {
            try
            {
                using (var sr = new StreamReader(@"C:nothing.dat"))
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
