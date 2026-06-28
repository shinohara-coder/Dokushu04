using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace Pro07
{
    internal class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        public virtual string Show()
        {
            return $"名前は{this.LastName}{this.FirstName}です。";
        }
    }
}
