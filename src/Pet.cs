using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Pet
    {
        public string Name { get; private set; }
        public string Species { get; private set; }

        public Pet(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
