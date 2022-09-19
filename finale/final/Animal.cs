using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    class Animal : IComparable
    {
        DBConnection db;
        public Animal[] animals;
        ArrayList arraylists = new ArrayList();
        Hashtable hashtable = new Hashtable();

        public int ID { get; set; }
        public float Weight { get; set; }
        public string Name { get; set; }
        public bool EatMeat { get; set; }
        public string Continent { get; set; }
        public Animal()
        {
            db = new DBConnection();
            animals = db.CreateArray(animals);
            for (int i = 0; i < animals.Length; i++)
            {
                arraylists.Add(animals[i]);
                hashtable.Add(animals[i].GetHashCode(), animals[i]);
            }
        }
        public Animal(int id, string name, float weight, bool meat, string continent)
        {
            Name = name;
            Weight = weight;
            EatMeat = meat;
            Continent = continent;
            ID = id;
        }
        public override string ToString()
        {
            return $"ID ={ID} | Name ={Name} | weight = {Weight} Kg | eat Meat = {EatMeat} | continent = {Continent} |***";
        }
        public void sort(string sort)
        {
            if (sort == "Name")
            {
                Array.Sort(animals);
                foreach (Animal item in animals)
                {
                    Console.WriteLine(item);
                }
            }
            else if (sort == "Weight")
            {
                Array.Sort(animals, new SortAnimalByWeight());
                foreach (Animal item in animals)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public int CompareTo(object obj)
        {
            if (obj is Animal)
            {
                return Name.CompareTo((obj as Animal).Name);
            }
            return -1;
        }
        public List<VegetarianAnimals> CreateVegArray()
        {
            List<VegetarianAnimals> vegLIst = new List<VegetarianAnimals>();
            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i].EatMeat == false)
                {
                    vegLIst.Add(new VegetarianAnimals(animals[i].ID, animals[i].Name, animals[i].Weight, animals[i].EatMeat, animals[i].Continent));
                }
            }
            return vegLIst;
        }
        public void PrintArraylist()
        {
            Console.WriteLine("ArrayList Style!");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
        public void PrintHash()
        {
            Console.WriteLine("HashTable Style!");
            for (int i = 0; i < hashtable.Count; i++)
            {
                Console.WriteLine("Key: " + animals[i].GetHashCode() + " Animal: " + animals[i]);
            }
        }
        public override int GetHashCode()
        {
            return ID;
        }
        public void Print()
        {
            foreach (var item in animals)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

}








