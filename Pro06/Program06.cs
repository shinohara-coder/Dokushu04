namespace Pro06
{
    internal class Circle
    {
        private double _radius;

        public Circle(double radius)
        {
            this._radius = radius;
        }

        public Circle() : this(1) {}

        public double GetArea()
        {
            return Math.PI * this._radius * this._radius;
        }
    }
    
    internal class LockBasic
    {
        static void Main(string[] args)
        {
            var c = new Circle();
            Console.WriteLine(c.GetArea());
        }
    }   
}
