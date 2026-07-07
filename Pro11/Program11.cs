using IronPython.Hosting;
using Microsoft.Scripting;
using System.Diagnostics;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Pro10
{
    internal class MyAppException : Exception
    {
        public MyAppException() { }

        public MyAppException(string message) : base(message)
        {
        }

        public MyAppException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public MyAppException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
    
    internal class ArgParams
    {
        static void Main(string[] arngs)
        {
            var i = int.MaxValue;
            Console.WriteLine(++i);
            throw new MyAppException("例外発生！");
        }
    }

}
