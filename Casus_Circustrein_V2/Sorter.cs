using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_Circustrein_V2
{
    class Sorter
    {
        public List<Wagon> Wagons { get; private set; }

        public void DistributeAnimals(List<Animal> animals)
        {
            AddNewWagonToList();

            foreach (Animal animal in animals)
            {
                bool IsAnimalAdded = false;

                foreach (Wagon wagon in Wagons)
                {
                    if (!IsWagonFull(animal, wagon) && animal.IsCompatible(wagon))
                    {
                        wagon.AddAnimalToWagon(animal);
                        IsAnimalAdded = true;
                        break;
                    }
                }

                if (!IsAnimalAdded)
                {
                    AddNewWagonToList(animal);
                }
            }
        }

        public bool IsWagonFull(Animal animal, Wagon wagon)
        {
            if (animal.Size <= (10 - wagon.WagonContent))
            {
                return false;
            } else
            {
                return true;
            }           
        }

        public void AddNewWagonToList(Animal animal = null)
        {
            Wagon wagon = new Wagon();
            
            if (animal != null)
            {
                wagon.AddAnimalToWagon(animal);
            }

            Wagons.Add(wagon);

        }
    }
}
