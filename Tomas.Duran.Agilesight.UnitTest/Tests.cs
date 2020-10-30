using Moq;
using NUnit.Framework;
using Tomas.Duran.Agilesight.Test;

namespace Tomas.Duran.Agilesight.UnitTest
{
    public class Tests
    {
        private Mock<IDictionary> dictonary;

        [SetUp]
        public void Setup()
        {
            this.dictonary = new Mock<IDictionary>();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}