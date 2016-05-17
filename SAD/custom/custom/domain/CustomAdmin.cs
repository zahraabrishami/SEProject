using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domain
{
    public class CustomAdmin : Employee
    {
        public CustomAdmin(string name, string family, string staffNo, string password)
        : base(name, family, staffNo, password) { }
    }
}
