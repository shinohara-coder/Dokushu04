global using static System.Console;

namespace Pro16.Util
{
    internal partial class MyNewPatial
    {
        public partial string LongText()
        {
            return "特定のルールで自動生成された、冗長な文字列の例";
        }
    }

    internal partial class MyNewPatial
    {
        public partial string LongText();
        static void Main(string[] args)
        {
            var np = new MyNewPatial();
            WriteLine(np.LongText());
        }
    }
}
