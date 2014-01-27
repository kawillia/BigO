using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BigO.Tests
{
    [TestClass]
    public class ListProcessorTests
    {
        private Random random;
        private ListProcessor processor;

        public ListProcessorTests()
        {
            random = new Random(1);
            processor = new ListProcessor();
        }

        [TestMethod]
        public void FindDuplicatesInTwoLists()
        {
            var listOne = new List<Int32>();
            var listTwo = new List<Int32>();

            PopulateList(listOne, 100000);
            PopulateList(listTwo, 100000);

            var results = processor.FindDuplicates(listOne, listTwo);
        }

        [TestMethod]
        public void AddItemsToList()
        {
            var listOne = new List<Int32>();
            var listTwo = new List<Int32>();

            PopulateList(listOne, 100000);

            Assert.IsTrue(listOne.Count > 0);
        }

        private void PopulateList(List<Int32> list, Int32 numberOfIntegers)
        {
            for (var i = 0; i < numberOfIntegers; i++)
                list.Add(random.Next());
        }
    }
}
