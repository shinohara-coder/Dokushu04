using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Numerics;
using System.Text;

namespace Pro06
{
    internal class BusinessPeroson : Person
    {
        public string Work()
        {
            return $"{this.LastName}{this.FirstName}は、働きます。";
        }

        public new string Show()
        {
            return $"会社員の{this.LastName}{this.FirstName}です。";
        }
    }

    internal class EliteBusinessPerson : BusinessPeroson
    {
        public new string Work()
        {
            var reslut = base.Work();
            return $"{reslut}いつでもテキパキと。";
        }
    }

    internal class LockBasic
    {
        static void Main(string[] args)
        {
            var ep = new EliteBusinessPerson
            { 
                FirstName = "一郎", 
                LastName = "田中" 
            };

            Console.WriteLine(ep.Work());
        }
    }   
}
