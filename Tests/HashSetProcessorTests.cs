using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BigO.Tests
{
    [TestClass]
    public class HashSetProcessorTests
    {
        private const Int32 NumberOfItems = 100000;

        private HashSetProcessor processor;
        private RandomCollectionPopulator randomCollectionPopulator;

        public HashSetProcessorTests()
        {
            processor = new HashSetProcessor();
            randomCollectionPopulator = new RandomCollectionPopulator();
        }

        [TestMethod]
        public void FindDuplicatesInTwoHashSets()
        {
            var listOne = new HashSet<Int32>();
            var listTwo = new HashSet<Int32>();

            randomCollectionPopulator.Populate(listOne, NumberOfItems);
            randomCollectionPopulator.Populate(listTwo, NumberOfItems);

            processor.FindDuplicates(listOne, listTwo);
        }

        [TestMethod]
        public void AddItemsToHashSet()
        {
            var listOne = new HashSet<Int32>();
            var listTwo = new HashSet<Int32>();

            randomCollectionPopulator.Populate(listOne, NumberOfItems);
        }
    }
}
