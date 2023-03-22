using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class Person
    {
        public string name;
        public object pet;

        // Constructor to set all the variables.
        // The two constructors above call this when they are used.
        public Person(string name, object pet)
        {
            this.name = name;
            this.pet = pet;
            
        }

        public override string ToString()
        {
            return this.name + ", Has a friend called " + pet;
        }

    }
}
