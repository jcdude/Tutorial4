using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial4
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int roleId { get; set; }

        public Role role { get; set; }
    }
}
