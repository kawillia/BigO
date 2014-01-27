using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO
{
    public class HashSetProcessor
    {
        public IEnumerable<T> FindDuplicates<T>(HashSet<T> hashOne, HashSet<T> hashTwo)
        {
            return hashOne.Intersect(hashTwo);
        }
    }
}
