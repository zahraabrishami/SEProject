using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domain
{
    public class Employee
    {
        public string name { get; set; }
        public string family { get; set; }
        public string staffNo { get; set; }
        public string password { get; set; }

        public Employee(string _name, string _family, string _staffNo, string _password)
        {
            name = _name;
            family = _family;
            staffNo = _staffNo;
            password = _password;
        }

       
    }
    
}
