1. Explain the meaning of Unit testing and its difference on comparison with Functional testing
Unit testing means testing small parts of the code like one function or one method to check if it is giving correct result. In unit test we don't test full application, only small piece of logic. Sometimes we also use mock to fake other parts.Whereas, in Functional testing we test full features or flows of the application. Like checking login page is working fully. It is more like checking the system from user point of view.

2. List various types of testing
Unit testing – testing one function or method

Functional testing – checking full working of one feature

Regression testing – checking if the new code did not break anything that was working before

Integration Testing – After unit testing, we test if different modules or components work together. For example, checking if login page works together with database properly.

3. Understand the benefit of automated testing
Automated testing saves time because we can run all tests again and again without doing it manually. It is fast and helps to find mistakes early. It also helps when we change code later, so we can check if old code is still working fine.

4. Explain what is loosely coupled & testable design
Loosely coupled means one class does not depend strongly on another class. We can pass data or object using interface or constructor. This makes the code more easy to test.

If code is loosely coupled, we can pass fake object during testing so that we don’t depend on real services like email or database.

5. Write your first testing program to validate a calculator addition operation
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
        [TestCase(0, 9, 9)]
        public void TestAddition(double a, double b, double expected)
        {
            var result = calc.Addition(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
6. Understand the need of [SetUp], [TearDown] & [Ignore] attributes
[SetUp] is used to create object or setup before every test runs

[TearDown] is used to clear memory or object after test runs

[Ignore] is used when we want to skip a test for some reason

7. Explain the benefit of writing parameterised test cases
When we use [TestCase], we can pass different inputs to same test method. This saves time and lines of code. We don’t need to write same test again and again for different values. Also we can test with many values to make sure the function works properly.

