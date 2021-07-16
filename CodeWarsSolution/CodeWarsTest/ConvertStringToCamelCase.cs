using System;
using CodeWars.Challenge_Solutions;
using NUnit.Framework;

namespace CodeWarsTest
{
    class ConvertStringToCamelCase
    {
        [TestCase("Convert_String_To_Camel_Case", "convertStringToCamelCase")]
        [TestCase("Hello Again World", "helloAgainWorld")]
        [TestCase("Its-Me-You're-Looking-For", "helloAgainWorld")]
        public void TestStringConversion_ForCorrectOutput(String str, String expected)
        {
            Assert.That(ConvertStringToCamelCase.Solution(str), Is.EqualTo(expected));
        }
    }
}
