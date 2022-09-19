using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    class SortAnimalByWeight : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Animal && y is Animal)
            {
                return (x as Animal).Weight.CompareTo((y as Animal).Weight);
            }
            return -2;
        }
    }
}
