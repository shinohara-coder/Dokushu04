namespace Pro22
{
    internal class IteratorBasic
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.firstName = "広樹";
            p.lastName = "篠原";
            Console.WriteLine(p.Show(52));
        }
    }
}
