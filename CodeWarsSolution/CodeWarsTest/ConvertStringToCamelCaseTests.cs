using System;
using CodeWars.Challenge_Solutions;
using NUnit.Framework;

namespace CodeWarsTest
{
    class ConvertStringToCamelCaseTest
    {
        [TestCase("Convert_String_To_Camel_Case", "convertStringToCamelCase")]
        [TestCase("Hello Again World", "helloAgainWorld")]
        [TestCase("Avengers-Endgame", "avengersEndgame")]
        public void TestStringConversion_ForCorrectOutput(String str, String expected)
        {
            Assert.That(ConvertStringToCamelCase.Solution(str), Is.EqualTo(expected));
        }
    }
}
