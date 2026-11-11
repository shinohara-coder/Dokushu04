global using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal class PassRefBasic
    {
        static void Main(string[] args)
        {
            try
            {
                //checked
                //{
                //    var i = int.MaxValue;
                //    WriteLine(++i);
                //}

                var i = int.MaxValue;
                WriteLine(checked(++i));
                //WriteLine(unchecked(++i));
            }
            catch (OverflowException ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}


