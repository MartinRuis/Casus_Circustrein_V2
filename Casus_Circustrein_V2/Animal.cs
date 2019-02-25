using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_Circustrein_V2
{
    abstract class Animal
    {
        public int Size { get; private set; }

        public Animal(int size)
        {
            Size = size;
        }

        abstract public bool IsCompatible(Wagon wagon);

        public override string ToString()
        {
            return base.ToString() + " Size = " + Size;
        }
    }
}
