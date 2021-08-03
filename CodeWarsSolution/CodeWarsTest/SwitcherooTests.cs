using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars.Challenge_Solutions;
using NUnit.Framework;

namespace CodeWarsTests
{
    class SwitcherooTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("bac", Switcheroo.SwitcherooMethod("abc"));
            Assert.AreEqual("bbbacccabbb", Switcheroo.SwitcherooMethod("aaabcccbaaa"));
            Assert.AreEqual("ccccc", Switcheroo.SwitcherooMethod("ccccc"));
        }
    }
}
