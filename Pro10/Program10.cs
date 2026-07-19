namespace Pro10
{
    internal class Coodinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static bool operator true(Coodinate c)
        {
            return c.X >= 0 && c.Y >= 0;
        }

        public static bool operator false(Coodinate c)
        {
            return c.X < 0 || c.Y < 0;
        }

        public override string ToString()
        {
            return $"X: {this.X} Y: {this.Y}";
        }
    }
    internal class MySingleton
    {
        static void Main(string[] args)
        {
            var c1 = new Coodinate() { X = 10, Y = 20 };
            var c2 = new Coodinate() { X = 10, Y = -10 };

            hantei(c1, nameof(c1));
            hantei(c2, nameof(c2));
        }

        static void hantei(Coodinate c, string varName)
        {
            if (c)
            {
                Console.WriteLine($"変数\"{varName}\"は真です。");
            }
            else
            {
                Console.WriteLine($"変数\"{varName}\"は偽です。"); 
            }
        }
    }
}

