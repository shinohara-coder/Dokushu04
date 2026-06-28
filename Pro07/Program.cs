using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace Pro07
{
    internal class BusinessPeroson : Person
    {
        public string Work()
        {
            return $"{this.LastName}{this.FirstName}は、働きます。";
        }

        public override string Show()
        {
            return $"会社員の{this.LastName}{this.FirstName}です。";
        }
    }

    internal class AsyncBasic
    {
        static void Main(string[] args)
        {
            var bp = new BusinessPeroson
            {
                FirstName = "一郎",
                LastName = "小渕"
            };

            Console.WriteLine(bp.Work());
            Console.WriteLine(bp.Show());
        }   
    }
}
