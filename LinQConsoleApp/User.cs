using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQConsoleApp
{
    internal class User
    {
        public string name;
        public string lName;
        public int age;

        public User(string _name, string _Lname, int _age)
        {
            this.name = _name;
            this.lName = _Lname;
            this.age = _age;
        }
    }
}
