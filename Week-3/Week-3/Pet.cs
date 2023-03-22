using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class Pet
    {
        public string name;
        public string type;

        // Constructor to set all the variables.
        // The two constructors above call this when they are used.
        public Pet(string name, String type)
        {
            this.name = name;
            this.type = type;
        }

        public override string ToString()
        {
            return this.name + " (" + this.type + ")";
        }
    }
}
