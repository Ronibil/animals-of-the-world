using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    class VegetarianAnimals : Animal
    {

        public VegetarianAnimals()
        {

        }
        public VegetarianAnimals(int id, string name, float weight, bool meat, string continent) : base(id, name, weight, meat, continent)
        {


        }

        public override string ToString()
        {
            return base.ToString() + " |Meat is murder! |***";
        }



    }
}
