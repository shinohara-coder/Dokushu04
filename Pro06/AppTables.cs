using System;
using System.Collections.Generic;
using System.Text;

namespace Pro06
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
            return $"{Title}（{Publisher}）{Price}円 {Publisher:d}刊行";
        }
    }

    internal class Review
    {
        public string Isbn { get; set; } = "";
        public string Name { get; set; } = "";
        public string Body { get; set; } = "";
    }
    internal static class AppTables
    {

    }
}
