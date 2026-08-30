namespace Pro19
{
    internal class PassRefBasic
    {           
        static void Main(string[] args)
        {
            //object obj = 1234;
            //object obj = "abc";
            //Console.WriteLine(obj switch
            //{
            //    123 => "123です。",
            //    int i => $"数値: {i}",
            //    string s => $"文字列: {s}",
            //    _ => "意図しない値"
            //});

            //var t = ("C#", "Java", "Visual Basic");
            //var t = ("Python", "Ruby", "JavaScript");
            //var t = ("Kotlin", "TypeScript", "");
            var t = ("Kotlin", "VBA", "C++");
            Console.WriteLine(t switch {
                ("C#", "Java", "Visual Basic") => "コンパイル言語",
                ("Python","Ruby", var lang) => $"インタプリター言語{lang}",
                ("Kotlin","TypeScript",_) => "トランスコンパイル言語",
                _ => "その他"
            });
        }

    }
}
