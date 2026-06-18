//#define DEBUG
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using SelfCSharp.Chap09.Priority1;
//using MyUtil = SelfCSharp.Chap09.Priority2.MyUtil;

namespace SelfCSharp.Chap09.Priority1
{
    internal class LambdaCapture
    {
        static void Main(string[] args)
        {
            var set = new SortedSet<int> { 30, 60, 10, 15 };

            set.Add(10);
            set.Add(5);
            set.Remove(60);

            //foreach (var s in set)
            //{
            //    func(s);
            //}

            var set2 = new SortedSet<int> { 10, 15, 30 };
            //func(set.IsSupersetOf(set2));

            set.ExceptWith(new HashSet<int> { 15, 30 });
            set.Remove(10);
            Printset(set);
        }

        static void func(object? str)
        {
            Console.WriteLine(str);
        }

        static void Printset<T>(SortedSet<T> set)
        {
            foreach (var v in set)
            {
                func(v);
            }
        }
    }
}

