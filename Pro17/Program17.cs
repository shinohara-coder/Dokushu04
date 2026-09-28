using System.Runtime.InteropServices;
using static System.Console;

namespace Pro17
{
    internal class DelegateAnonymous
    {
        internal struct MyStruct()
        {
            public string FirstName { get; set; } = "";
            public string LastName { get; set; } = "";

            public int Age { get; set; } = 0;

            public override string ToString()
            {
                return $"{this.LastName}{this.FirstName}";
            }
        }
        static void Main(string[] args)
        {
            //int i = int.MinValue;
            //WriteLine($"{Convert.ToString(i, 2)}");
            //WriteLine($"{Convert.ToString(i >> 5, 2)}");

            //uint m = (uint)i;
            //WriteLine($"{Convert.ToString(m, 2)}");
            //WriteLine($"{Convert.ToString(m >> 5, 2),32}");

            WriteLine(sizeof(decimal));
            unsafe
            {
                WriteLine(sizeof(MyStruct));
            }
        }
    }
}
