using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;

namespace Pro19
{
    
    internal class IteratorBasic
    {
        public record Person(string FirstName, string LastName, int Age);
        static void Main(string[] args)
        {
            var p1 = new Person("太郎", "山田", 10);
            var p2 = new Person("太郎", "山田", 10);

            Console.WriteLine(p1);
            Console.WriteLine(p1 == p2);
            (string fname, string lname, int age) = p1;
            Console.WriteLine(lname);
        }

    }
}
