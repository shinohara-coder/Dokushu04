global using static System.Console;
using System.Runtime.Serialization;

namespace Pro24
{
    internal class MyAppException : Exception
    {
        public MyAppException()
        {

        }

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

    internal class PassBasic
    {
        static void Main(string[] args)
        {
            try
            {
                //throw new MyAppException("例外発生");
                //throw new MyAppException("例外発生", new AggregateException());
                throw new MyAppException("例外発生", new AggregateException());
            }
            catch (MyAppException ex)
            {
                WriteLine(ex.Data);
                WriteLine(ex.InnerException);
                WriteLine(ex.HResult);
                WriteLine(ex.Message);
            }
        }
    }
}
