using NUnit.Framework;

namespace AlphabetWars
{
    [TestFixture]
    public class TestKata
    {
        [TestCase("abde[fgh]ijk", "abdefghijk", TestName = "all letters survive because there is no #")]
        public void AlphabetWarTest(string expected, string input)
        {
            string actual = Kata.AlphabetWar(input);
            Assert.AreEqual(expected, actual);
        }
    }
}