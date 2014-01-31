using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BigO.Tests
{
    [TestClass]
    public class AddTests
    {
        private const Int32 NumberOfItems = 1000000;

        private RandomCollectionPopulator randomCollectionPopulator;

        public AddTests()
        {
            randomCollectionPopulator = new RandomCollectionPopulator();
        }

        [TestMethod]
        public void UsingSet()
        {
            var hash = new HashSet<Int32>();
            randomCollectionPopulator.Populate(hash, NumberOfItems);
        }

        [TestMethod]
        public void UsingList()
        {
            var list = new List<Int32>();
            randomCollectionPopulator.Populate(list, NumberOfItems);
        }

        [TestMethod]
        public void UsingLinkedList()
        {
            var list = new LinkedList<Int32>();
            randomCollectionPopulator.Populate(list, NumberOfItems);
        }
    }
}
