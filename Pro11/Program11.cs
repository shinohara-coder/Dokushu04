using System.Text.RegularExpressions;

namespace Pro11
{
    internal class Message
    {
        private int _number;
        static Message()
        {
            Console.WriteLine("静的コンストラクター");
        }

        public Message(int number)
        {
            this._number = number;
            Console.WriteLine($"通常のコンストラクター{this._number}");
        }
    }
    
    internal class LockBasicBad
    {
        static void Main(string[] args)
        {
            var m1 = new Message(1);
            var m2 = new Message(2);
            var m3 = new Message(3);
            var m4 = new Message(4);
            var m5 = new Message(5);
        }
    }
}

