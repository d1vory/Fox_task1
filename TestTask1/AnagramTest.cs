using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace TestTask1
{
    [TestClass]
    public class AnagramTest
    {
        [TestMethod]
        public void TestReverse()
        {
            string[] initialInput = { 
                "",
                "a1bcd efg!h",
                "  a1bcd    efg!h",
                "             ",
                "   abc       qwd1e     ",
                "!@#$%^  ",
                "word otherword planet" 
            };
            string[] reversedInput = {
                "", 
                "d1cba hgf!e",
                "  d1cba    hgf!e",
                "             ",
                "   cba       edw1q     ",
                "!@#$%^  ",
                "drow drowrehto tenalp" 
            };
            for (int i = 0; i < initialInput.Length; i++)
            {
                string input = initialInput[i];
                string expectedString = reversedInput[i];
                string actualString = Anagram.Reverse(input);
                Assert.AreEqual(expectedString, actualString);
            }

            Assert.ThrowsException<System.ArgumentNullException>(() => Anagram.Reverse(null));

        }
    }
}