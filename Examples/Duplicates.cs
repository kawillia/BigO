using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO
{
    public class Duplicates
    {
        public static IEnumerable<T> UsingLists<T>(List<T> listOne, List<T> listTwo)
        {
            var duplicates = new List<T>();

            for (var i = 0; i < listOne.Count; i++)
                if (listTwo.Contains(listOne[i]))
                    duplicates.Add(listOne[i]);

            return duplicates;
        }

        public static IEnumerable<T> UsingSets<T>(HashSet<T> hashOne, HashSet<T> hashTwo)
        {
            return hashOne.Intersect(hashTwo);
        }
    }
}
