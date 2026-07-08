namespace Pro18
{
    internal struct MutableValue
    {
        public string Name { get; set; }

        public MutableValue()
        {
            this.Name = "名無権兵衛";
        }

        public void Update(string name)
        {
            this.Name = name;
            Console.WriteLine("Update method is finished!!");
        }

        public void UpdateNest(string name)
        {
            this.Name = name;
        }
    }
    internal class RefForeach
    {
        static readonly MutableValue mv = new();
        static void Main(string[] args)
        {
            mv.Update("佐藤栄作");
            Console.WriteLine(mv.Name);
        }
    }
}
