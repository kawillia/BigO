using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO
{
    public class Distinct
    {
        public static IEnumerable<T> UsingLinq<T>(List<T> collection)
        {
            return collection.Distinct();
        }

        public static IEnumerable<T> UsingLoop<T>(List<T> collection)
        {
            var items = new List<T>();

            foreach (var item in collection)
            {
                if (items.Contains(item) == false)
                    items.Add(item);
            }

            return items;
        }
    }
}
