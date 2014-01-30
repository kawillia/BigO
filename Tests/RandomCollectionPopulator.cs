using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO.Tests
{
    public class RandomCollectionPopulator
    {
        private Random random;

        public RandomCollectionPopulator()
        {
            random = new Random();
        }

        public void Populate(ICollection<Int32> collection, Int32 numberOfItems)
        {
            for (var i = 0; i < numberOfItems; i++)
                collection.Add(random.Next());
        }
    }
}
