using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dataAccess;

namespace domain
{
    public class LoginHandler
    {
        public Employee login(string _username, string _password)
        {
            Employee e = EmployeeDB.getEmployeeByLoginInfo(_username, _password);
            return e;
        }
    }
}
