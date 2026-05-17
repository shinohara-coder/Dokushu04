using System;
using System.Runtime.Serialization;

namespace Pro04.hoge
{
    internal class Book
    {
        public string Isbn { get; set; } = "";
        public string Title { get; set; } = "";
        public int Price { get; set; } = 0;
        public string Publisher { get; set; } = "";
        public DateTime Published { get; set; } = DateTime.Today;

        public override string ToString()
        {
            return $"{Title} ({Publisher}) {Price}円 {Published:d}刊行";
        }
    }

    internal class Review
    {

    }

    internal static class AppTavles
    {

    }
}
