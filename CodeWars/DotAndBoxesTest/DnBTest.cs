using DotAndBoxes;
using NUnit.Framework;

namespace DotAndBoxesTest
{
    public class DnBTest
    {
        [SetUp]
        public void TestInitialize()
        {
        }

        [Test]
        public void DnBBaseTest()
        {
            var moves = new int[][]
             {
                new[] { 0, 1 },
                new[] { 7, 8 },
                new[] { 1, 2 },
                new[] { 6, 7 },
                new[] { 0, 3 },
                new[] { 8, 5 },
                new[] { 3, 4 },
                new[] { 4, 1 },
                new[] { 4, 5 },
                new[] { 2, 5 },
                new[] { 7, 4 },
                new[] { 3, 6 }
             };
            var expected = new int[2] { 3, 1 };
            var actual = DnB.DotsAndBoxes(moves);
            Assert.AreEqual(expected, actual);
        }
    }
}