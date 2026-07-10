using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;

namespace Pro21
{

    internal class IteratorBasic
    {
        public record Person(string FirstName, string LastName, int Age);
        static void Main(string[] args)
        {
            var p = new Person("太郎", "山田", 10);
            var pc1 = p with { Age = 20 };
            var pc2 = p with { };

            Console.WriteLine(pc1);
            Console.WriteLine(pc2);
        }
    }
}
