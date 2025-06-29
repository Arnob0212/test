using NUnit.Framework;
using CalcLibrary;

namespace CalcLibraryTests
{
    [TestFixture]
    public class CalculatorTests
    {
        SimpleCalculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new SimpleCalculator();
        }

        [TearDown]
        public void Teardown()
        {
            calc = null;
        }

        [Test]
        [TestCase(5, 3, 8)]
        [TestCase(-2, 2, 0)]
        [TestCase(0, 0, 0)]
        public void TestAddition(double a, double b, double expected)
        {
            var result = calc.Addition(a, b);
            Assert.That(result, Is.EqualTo(expected).Within(0.001));
        }
    }
}
