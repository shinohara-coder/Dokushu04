using System;
using System.Runtime.Serialization;

namespace Dokushu04
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception ex1 = new MyAppException();

            Exception ex2 = new MyAppException("エラーが発生しました！");

            Exception inner = new FormatException("元の数字変換エラー");
            Exception ex3 = new MyAppException("計算中に問題が発生しました。", inner);

            var info = new SerializationInfo(typeof(MyAppException), new FormatterConverter());
            var context = new StreamingContext();
            info.AddValue("ClassName", "MyAppException");
            info.AddValue("Message", "シリアル化経由のメッセージ");
            info.AddValue("StackTraceString", null);
            info.AddValue("ExceptionMethod", null);
            //info.AddValue("HResult", 0);
            info.AddValue("Source", null);
            info.AddValue("InnerException", null);

            Exception ex4 = new MyAppException(info, context);

            Console.WriteLine("例外を投げます。");
            throw ex4;
        }
    }

    internal class MyAppException : Exception
    { 
        public MyAppException() { }

        public MyAppException(string message) : base(message) { }

        public MyAppException(string message, Exception innerException) : base(message, innerException) { }

        public MyAppException(SerializationInfo info, StreamingContext context) : base(info, context) { }

    }
}
