using Moq;
using MoqExercise;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var mock = new Mock<IFoo>();
            mock.Setup(foo => foo.DoSomething("ping")).Returns(true);

            var expected = true;

            var actual = mock.Object.DoSomething("hello");

            Assert.AreEqual(expected, actual);
        }
    }
}