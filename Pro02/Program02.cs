using System.Numerics;
using static System.Console;

namespace SelfCSharp.Chap02
{
    internal class LockBasicBad
    {
        static void Main(string[] args)
        {
            //var array1 = new[] { "dog", "cat", "mouse", "fox", "lion" };
            //Array.Sort(array1);
            //WriteLine(string.Join(" & ", array1));
            //WriteLine(Array.BinarySearch(array1, "mouse"));

            //var array2 = new[] { "あ", "い", "う", "え", "お" };
            //var array3 = new string[5];

            //Array.Resize(ref array1, array1.Length + 3);
            //WriteLine(string.Join(" & ", array1));

            var multi1 = new string[,] {
                { "ハ","ニ","ホ","へ","ト" }, 
                { "ど","れ","み","ふぁ","そ" } 

            };
            var multi2 = new string[2, 3];
            Array.Copy(multi1, 4, multi2, 0, 5);
            foreach(var v in multi2)
            {
                WriteLine(v);
            }
        }
    }
}


