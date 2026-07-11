using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;
using static Pro22.MyClass;

namespace Pro22
{

    internal class MyClass
    {
        internal class MyHelper
        {
            public void Show()
            {
                Console.WriteLine("Nested Class is running!");
            }
        }

        public void Run()
        {
            var helper = new MyHelper();
            helper.Show();
        }
    }
    internal class IteratorBasic
    {
        static void Main(string[] args)
        {
            var c = new MyClass();
            c.Run();

            var h = new MyHelper();
            h.Show();
        }
    }
}
