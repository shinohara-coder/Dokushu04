using System;
using System.Collections.Generic;
using System.Text;

namespace Pro14
{
    internal partial class MyPartial
    {
        public string Greet()
        {
            return $"こんにちは{this.LastName}{this.FirstName}さん！";
        }
    }
}
