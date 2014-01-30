using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BigO.Tests
{
    [TestClass]
    public class DistinctTests
    {
        private const Int32 NumberOfItems = 100000;

        private RandomCollectionPopulator randomCollectionPopulator;
        private List<Int32> items;

        public DistinctTests()
        {
            randomCollectionPopulator = new RandomCollectionPopulator();
            items = new List<Int32>();
        }

        [TestInitialize]
        public void TestInitialize()
        {
            randomCollectionPopulator.Populate(items, NumberOfItems);
        }

        [TestMethod]
        public void UsingLinq()
        {
            var distintItems = Distinct.UsingLinq(items);
            distintItems.ToList();
        }

        [TestMethod]
        public void UsingLoops()
        {
            var distinctItems = Distinct.UsingLoop(items);
            distinctItems.ToList();
        }
    }
}
