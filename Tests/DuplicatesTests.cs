using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BigO.Tests
{
    [TestClass]
    public class DuplicatesTests
    {
        private const Int32 NumberOfItems = 1000;

        private RandomCollectionPopulator randomCollectionPopulator;

        public DuplicatesTests()
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

            var duplicates = Duplicates.UsingSets(listOne, listTwo);
            duplicates.ToList();
        }

        [TestMethod]
        public void UsingLists()
        {
            var listOne = new List<Int32>();
            var listTwo = new List<Int32>();

            randomCollectionPopulator.Populate(listOne, NumberOfItems);
            randomCollectionPopulator.Populate(listTwo, NumberOfItems);

            var duplicates = Duplicates.UsingLists(listOne, listTwo);
            duplicates.ToList();
        }
    }
}
