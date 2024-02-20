using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace TestTask1
{
    [TestClass]
    public class AnagramTest
    {
        [TestMethod]
        public void TestReverseWord()
        {
            string[] initialWords = { "abcde", "efg!h", "a1bcd", "qw423yre", "!@#$%^"};
            string[] reversedWords = {"edcba", "hgf!e", "d1cba", "er423ywq", "!@#$%^"};
            for (int i = 0; i < initialWords.Length; i++)
            {
                string word = initialWords[i];
                string expectedWord = reversedWords[i];
                string actualWord = Anagram.ReverseWord(word);
                Assert.AreEqual(expectedWord, actualWord);
            }

            Assert.ThrowsException<System.ArgumentNullException>(() => Anagram.ReverseWord(""));
            Assert.ThrowsException<System.ArgumentNullException>(() => Anagram.ReverseWord(null));

        }

        [TestMethod]
        public void TestReverse()
        {
            string[] initialInput = { "a1bcd efg!h", "  a1bcd    efg!h", "             ", "   abc       qwd1e     "};
            string[] reversedInput = { "d1cba hgf!e", "  d1cba    hgf!e", "             ", "   cba       edw1q     " };
            for (int i = 0; i < initialInput.Length; i++)
            {
                string input = initialInput[i];
                string expectedString = reversedInput[i];
                string actualString = Anagram.Reverse(input);
                Assert.AreEqual(expectedString, actualString);
            }

            Assert.ThrowsException<System.ArgumentNullException>(() => Anagram.ReverseWord(""));
            Assert.ThrowsException<System.ArgumentNullException>(() => Anagram.ReverseWord(null));

        }
    }
}