using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO
{
    public class Except
    {
        public static IEnumerable<T> UsingContains<T>(List<T> collection, List<T> itemsToExclude)
        {
            var enabledGroupMembership = new List<T>();

            foreach (var group in collection)
            {
                if (itemsToExclude.Contains(group) == false)
                    enabledGroupMembership.Add(group);
            }

            return enabledGroupMembership;
        }

        public static IEnumerable<T> UsingSets<T>(HashSet<T> collection, HashSet<T> itemsToExclude)
        {
            return collection.Except(itemsToExclude);
        }
    }
}
