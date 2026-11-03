using System.Text.RegularExpressions;
using static System.Console;

namespace SelfCSharp.Chap09.Priority1
{
    internal class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        public virtual string Show()
        {
            return $"名前は{this.LastName}{this.FirstName}です。";

        }
    }
    internal class PassOut
    {
        static void Main(string[] args)
        {
            var p = new Person
            {
                FirstName = "次郎",
                LastName = "山本"
            };

            //WriteLine(p switch
            //{
            //    { FirstName: "太郎", LastName: var ln } => $"{ln}タロくん、こんにちは",
            //    { FirstName: "次郎", LastName: _ } => "鈴木次郎くんですね。",
            //    { FirstName: "一郎", LastName: var ln } => $"{ln}イチローくん、こんにちは",
            //    _ => "どなたですか？"
            //});

            //var point = 15;
            //WriteLine(point switch
            //{
            //    > 80 => "Excellent!!",
            //    > 60 => "Good!",
            //    > 40 => "Normal",
            //    _ => "Bad..."
            //});

            var drink = "ブランデー";

            WriteLine(drink switch
            {
                "日本酒" or "ビール" or "ワイン" => "醸造酒です。",
                "ブランデー" or "ウィスキー" => "蒸留酒です。",
                _ => "不明"
            });
        }
    }
}

