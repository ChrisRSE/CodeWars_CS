using System;
using NUnit.Framework;
using CodeWars.Challenge_Solutions;

namespace CodeWarsTest
{
    class TakeATenMinWalkTest
    {
        [TestCase(new string[] {"n", "s", "n", "s", "n", "s", "n", "s", "n", "s"}, true)]
        [TestCase(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }, false)]
        [TestCase(new string[] { "w" }, false)]
        [TestCase(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }, false)]

        public static void TakeATenMinWalk_ReturnsCorrectly(string[] str, bool expected)
        {
            Assert.That(TakeATenMinWalk.Solution(str), Is.EqualTo(expected));
        }
    }
}
