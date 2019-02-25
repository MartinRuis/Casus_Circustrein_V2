using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_Circustrein_V2
{
    class Wagon
    {
        private List<Animal> animals = new List<Animal>();
        public int WagonContent { get; private set; }
        public List<Animal> Animals { get { return animals; } private set {; } }

        public void AddAnimalToWagon(Animal animal)
        {
            animals.Add(animal);
            WagonContent += animal.Size;
        }

        public override string ToString()
        {
            string returnString = "Wagon: ";
            foreach (Animal animal in animals)
            {
                returnString += animal.ToString();
                returnString += "; ";
            }


            return returnString;
        }
    }
}
