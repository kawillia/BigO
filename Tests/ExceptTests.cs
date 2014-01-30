using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BigO.Tests
{
    [TestClass]
    public class ExceptTests
    {
        private const Int32 NumberOfItems = 10;
        private const Int32 NumberToExclude = 10;

        private RandomCollectionPopulator randomCollectionPopulator;

        public ExceptTests()
        {
            randomCollectionPopulator = new RandomCollectionPopulator();
        }

        [TestMethod]
        public void UsingSets()
        {
            var setOne = new HashSet<Int32>();
            var setTwo = new HashSet<Int32>();

            randomCollectionPopulator.Populate(setOne, NumberOfItems);
            randomCollectionPopulator.Populate(setTwo, NumberToExclude);

            var enabledMembership = Except.UsingSets(setOne, setTwo);
            enabledMembership.ToList();
        }

        [TestMethod]
        public void UsingContains()
        {
            var listOne = new List<Int32>();
            var listTwo = new List<Int32>();

            randomCollectionPopulator.Populate(listOne, NumberOfItems);
            randomCollectionPopulator.Populate(listTwo, NumberToExclude);

            var enabledMembership = Except.UsingContains(listOne, listTwo);
            enabledMembership.ToList();
        }
    }
}
