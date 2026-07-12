namespace Pro25.hoge
{
    internal partial class MyPartialMethod
    {
        static partial void Log();
        static partial void Greet();
        
        static void Main(string[] args)
        {
            Log();
            Greet();
        }
    }
}
