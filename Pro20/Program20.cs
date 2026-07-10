using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;
using Pro20.IntExtensions;

namespace Pro20
{
    internal record Person
    { 
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public int Age { get; init; }

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }
    internal class IteratorBasic
    {
        static void Main(string[] args)
        {
            var p1 = new Person("太郎", "山田", 10);
            var p2 = new Person("太郎", "山田", 10);

            Console.WriteLine(p1);
            Console.WriteLine(p1 == p2);
            //(string fname, string lname, int age) = p1;
            //Console.WriteLine(lname);
        }
    }
}
