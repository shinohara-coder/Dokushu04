namespace Pro25.hoge
{
    internal partial class MyPartialMethod
    {   
        static void Main(string[] args)
        {
            int[][] data = new int[3][];
            data[0] = new int[] { 11, 12};
            data[1] = new int[] { 21, 22, 23, 24};
            data[2] = new int[] { 31, 32, 33};

            for (var i = 0; i < data.Length; i++)
            {
                for (var j = 0; j < data[i].Length; j++)
                {
                    Console.WriteLine($"data[{i}][{j}] = {data[i][j]}");
                }
                Console.WriteLine("--------------------");
            }

            Console.WriteLine(data.Rank);
        }
    }
}
