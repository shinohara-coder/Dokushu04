using System;
using System.Collections.Generic;
using System.Text;

namespace Pro13
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
