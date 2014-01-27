using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BigO.Tests
{
    [TestClass]
    public class HashSetProcessorTests
    {
        private Random random;
        private HashSetProcessor processor;

        public HashSetProcessorTests()
        {
            random = new Random(1);
            processor = new HashSetProcessor();
        }

        [TestMethod]
        public void FindDuplicatesInTwoHashSets()
        {
            var listOne = new HashSet<Int32>();
            var listTwo = new HashSet<Int32>();

            PopulateList(listOne, 100000);
            PopulateList(listTwo, 100000);

            var results = processor.FindDuplicates(listOne, listTwo);
        }

        [TestMethod]
        public void AddItemsToHashSet()
        {
            var listOne = new HashSet<Int32>();
            var listTwo = new HashSet<Int32>();

            PopulateList(listOne, 100000);

            var results = processor.FindDuplicates(listOne, listTwo);
        }

        private void PopulateList(HashSet<Int32> list, Int32 numberOfIntegers)
        {
            for (var i = 0; i < numberOfIntegers; i++)
                list.Add(random.Next());
        }
    }
}
