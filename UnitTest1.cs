using NUnit.Framework;

namespace customvsadapter
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }


        [Test]
        [Category("Mario")]
        public void Test2() {
            Assert.Pass();
        }
    }
}