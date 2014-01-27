using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO
{
    public class ListProcessor
    {
        public List<Int32> FindDuplicates(List<Int32> listOne, List<Int32> listTwo)
        {
            var duplicates = new List<Int32>();

            for (var i = 0; i < listOne.Count; i++)
                if (listTwo.Contains(i))
                    duplicates.Add(i);

            return duplicates;
        }


    }
}
