using System;
using NUnit.Framework;
using CodeWars.Challenge_Solutions;

namespace CodeWarsTest
{
    class DetectPangramTest
    {
        [TestCase(true, ("The quick brown fox jumps over the lazy dog."))]
        [TestCase(false, ("This is a unique sentence."))]
        public void TestsPanagram_ForCorrectReturn(bool expected, String str)
        {
;
            Assert.That(expected, Is.EqualTo(DetectPangram.Solution(str)));
        }
    }
}
