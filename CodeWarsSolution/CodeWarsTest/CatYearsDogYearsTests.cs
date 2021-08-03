using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars.Challenge_Solutions;

namespace CodeWarsTests
{
    class CatYearsDogYearsTests
    {
        [Test]
        public void One()
        {
            Assert.AreEqual(new int[] { 1, 15, 15 }, CatYearsDogYears.humanYearsCatYearsDogYears(1));
        }

        [Test]
        public void Two()
        {
            Assert.AreEqual(new int[] { 2, 24, 24 }, CatYearsDogYears.humanYearsCatYearsDogYears(2));
        }

        [Test]
        public void Ten()
        {
            Assert.AreEqual(new int[] { 10, 56, 64 }, CatYearsDogYears.humanYearsCatYearsDogYears(10));
        }
    }
}
