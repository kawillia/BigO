using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BigO.Tests
{
    [TestClass]
    public class IntersectTests
    {
        private const Int32 NumberOfItems = 100000;

        private RandomCollectionPopulator randomCollectionPopulator;

        public IntersectTests()
        {
            randomCollectionPopulator = new RandomCollectionPopulator();
        }

        [TestMethod]
        public void UsingSets()
        {
            var listOne = new HashSet<Int32>();
            var listTwo = new HashSet<Int32>();

            randomCollectionPopulator.Populate(listOne, NumberOfItems);
            randomCollectionPopulator.Populate(listTwo, NumberOfItems);

            var duplicates = Intersect.UsingSets(listOne, listTwo);
            duplicates.ToList();
        }

        [TestMethod]
        public void UsingLists()
        {
            var listOne = new List<Int32>();
            var listTwo = new List<Int32>();

            randomCollectionPopulator.Populate(listOne, NumberOfItems);
            randomCollectionPopulator.Populate(listTwo, NumberOfItems);

            var duplicates = Intersect.UsingLists(listOne, listTwo);
            duplicates.ToList();
        }
    }
}
