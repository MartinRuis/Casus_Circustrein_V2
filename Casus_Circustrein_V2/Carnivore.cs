using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_Circustrein_V2
{
    class Carnivore : Animal
    {
        public Carnivore(int size) : base(size) { }

        public override bool IsCompatible(Wagon wagon)
        {
            throw new NotImplementedException();
        }
    }
}
