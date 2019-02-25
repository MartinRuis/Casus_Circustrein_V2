﻿using System;
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
            if (wagon.Animals == null)
            {
                return true;
            } else
            {
                foreach (Animal animal in wagon.Animals)
                {
                    if (animal.Size <= Size)
                    {
                        return false;
                    } else if (animal is Carnivore && animal.Size > Size)
                    {
                        return false;
                    }
            }
            }
            return true;
           
        }
    }
}
