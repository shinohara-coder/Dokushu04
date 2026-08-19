using System.Runtime.CompilerServices;

namespace Pro08
{   
    internal class MySingleton
    {
        private static MySingleton instance = new MySingleton();
        //private MySingleton() { }
        public MySingleton() { }

        public static MySingleton Instance
        {
            get
            {
                return instance;
            }
        }
        static void Main(string[] args)
        {
            var ms1 = MySingleton.Instance;
            var ms2 = MySingleton.Instance;
            Console.WriteLine(ms1 == ms2);
        }
    }
}
