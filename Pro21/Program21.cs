namespace Pro21
{
    internal class EventBasic
    {
        static void Main(string[] args)
        {
            
        }

        static void OnKeyCommand(string data)
        {
            switch (data.ToLower())
            {
                case "c":
                    Console.WriteLine($"現在の時刻は{DateTime.Now}");
                    break;
                case "x":
                    var r = new Random();
                    Console.WriteLine($"乱数は{r.Next()}");
                    break;
            }
        }
    }
}
