namespace SelfCSharp.Chap09.Priority1
{
    public interface IHoge
    {
        void Log(string msg)
        {
            Console.WriteLine($"Log: {msg}");
        }
    }

    public class Hoge : IHoge { }

    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            var h = new Hoge();
            ((IHoge)h).Log("任意のメッセージ");
        }
    }
}

