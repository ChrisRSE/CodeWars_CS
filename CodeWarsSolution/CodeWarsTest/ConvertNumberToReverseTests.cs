using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars.Challenge_Solutions;

namespace CodeWarsTests
{
    class ConvertNumberToReverseTests
    {
        [TestCase(35231, new long[] { 1, 3, 2, 5, 3 })]
        [TestCase(990024, new long[] { 4, 2, 0, 0, 9, 9 })]
        public void TestArrayReversesSuccessfully(long number, long[] expected)
        {
            Assert.That(ConvertNumberToReverse.Digitize(number), Is.EqualTo(expected));
        }
    }
}
