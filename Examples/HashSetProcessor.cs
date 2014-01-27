using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO
{
    public class HashSetProcessor
    {
        public IEnumerable<Int32> FindDuplicates(HashSet<Int32> hashOne, HashSet<Int32> hashTwo)
        {
            return hashOne.Intersect(hashTwo);
        }
    }
}
