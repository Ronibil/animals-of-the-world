using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    class ZOO
    {
        public Animal[] animals;
        public ZOO(Animal[] animals)
        {
            this.animals = animals;
        }
        public List<Animal> this[string continent]
        {
            get
            {
                List<Animal> animalsList = new List<Animal>();
                
                for (int i = 0; i < animals.Length; i++)
                {
                    if (animals[i].Continent == continent)
                    {
                        animalsList.Add(animals[i]);
                    }
                }
                return animalsList;
            }
        }
        public Animal[] this[int id]
        {
            get
            {
                Animal[] animalset = new Animal[0];
                try
                {
                    if (id > animals.Length)
                    {
                        throw new IndexOutOfRangeException("There is no animal in this ID");
                    }
                    int index = 0;
                    Animal[] temp;
                    for (int i = 0; i < animals.Length; i++)
                    {
                        if (animals[i].GetHashCode() == id)
                        {
                            temp = (Animal[])animalset.Clone();
                            animalset = new Animal[animalset.Length + 1];
                            temp.CopyTo(animalset, 0);
                            animalset[index++] = animals[i];
                        }
                    } 
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                return animalset;
            }      
        } 

    }
}
