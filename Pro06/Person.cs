using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace Pro06
{
    internal class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        public string Show()
        {
            return $"名前は{this.LastName}{this.FirstName}です。";
        }
    }
}
