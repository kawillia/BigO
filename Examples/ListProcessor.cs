using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO
{
    public class ListProcessor
    {
        public IEnumerable<T> FindDuplicates<T>(List<T> listOne, List<T> listTwo)
        {
            var duplicates = new List<T>();

            for (var i = 0; i < listOne.Count; i++)
                if (listTwo.Contains(listOne[i]))
                    duplicates.Add(listOne[i]);

            return duplicates;
        }
    }
}
