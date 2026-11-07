using static System.Console;

namespace Pro12
{
    public interface IHoge
    {
        void Log(string msg)
        {
            WriteLine($"Log: {msg}");
        }
    }

    public class Hoge : IHoge 
    {
        public void Log(string msg)
        {
            WriteLine($"Hoge: {msg}");
        }
    }

    internal class ScopeBasic
    {

        static void Main(string[] args)
        {
            var h = new Hoge();
            //((IHoge)h).Log("任意のメッセージ");
            h.Log("クラスのメッセージ");
        }
    }
}

