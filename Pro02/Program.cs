using System;
using System.Runtime.Serialization;
using static System.Console;
using static System.Math;

namespace Dokushu04
{
    class Program
    {
        static void Main(string[] args)
        {
            throw new MyAppException("例外発生！");
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
