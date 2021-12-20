using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQConsoleApp
{
    internal class Person
    {

        public string name;
        public string lName;
        public int yearOfBirth; 

        public Person(string _name, string _Lname , int _yearOfBirth)
        {
            this.name = _name;
            this.lName = _Lname;
            this.yearOfBirth = _yearOfBirth;
        }

    }
}
