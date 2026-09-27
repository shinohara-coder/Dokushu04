using System.Threading.Tasks.Dataflow;
using static System.Console;

namespace Pro13
{
    internal class DelegateUse
    {
        static void Main(string[] args)
        {
            //var multi = new[,]
            //{
            //    {10,11,12 },
            //    {20,21,22 },
            //    {30,31,32 }
            //};

            //for (int i = 0;i<multi.GetLength(0);i++)
            //{
            //    for (int j=0; j<multi.GetLength(1);j++)
            //    {
            //        WriteLine($"multi[{i},{j}] = {multi[i, j]}");
            //    }
            //    WriteLine("\n");
            //}

            var jagged = new int[3][];
            jagged[0] = new[] { 10, 11, 12, 13 };
            jagged[1] = new[] { 20, 21 };
            jagged[2] = new[] { 30, 31, 32 };

            for (int i = 0; i < jagged.GetLength(0); i++)
            {
                for (int j = 0; j < jagged[i].GetLength(0); j++)
                {
                    WriteLine($"jagged[{i}][{j}] = {jagged[i][j]}");
                }
                WriteLine("\n");
            }
        }
    }
}
