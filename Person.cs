using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    internal struct Person
    {
        public string Name { get; set; }
        public byte Age { get; set; }

        public Person(string name, byte age)
        {
            Name = name;
            Age = age;
        }
    }
}
