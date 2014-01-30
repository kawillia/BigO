using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BigO.Tests
{
    [TestClass]
    public class ListProcessorTests
    {
        private const Int32 NumberOfItems = 100000;
        private RandomCollectionPopulator randomCollectionPopulator;
        private ListProcessor processor;

        public ListProcessorTests()
        {
            randomCollectionPopulator = new RandomCollectionPopulator();
            processor = new ListProcessor();
        }

        [TestMethod]
        public void FindDuplicatesInTwoLists()
        {
            var listOne = new List<Int32>();
            var listTwo = new List<Int32>();

            randomCollectionPopulator.Populate(listOne, NumberOfItems);
            randomCollectionPopulator.Populate(listTwo, NumberOfItems);
            
            processor.FindDuplicates(listOne, listTwo);
        }

        [TestMethod]
        public void AddItemsToList()
        {
            var listOne = new List<Int32>();

            randomCollectionPopulator.Populate(listOne, NumberOfItems);
        }
    }
}
