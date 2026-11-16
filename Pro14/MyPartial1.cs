using System;
using System.Collections.Generic;
using System.Text;

namespace Pro14
{
    internal partial class MyPartial
    {
        private string FirstName { get; set; } = "";
        private string LastName { get; set; } = "";

        public MyPartial(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string Show()
        {
            return $"名前は{this.LastName}{this.FirstName}です。";
        }
    }
}
