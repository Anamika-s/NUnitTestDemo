using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingDemo.Tests
{
    [TestFixture]
    class Class2
    {
        [Test , SetUp]
        
        public void Initialze()
        {

        }

        
        [TestCase(10,20,30)]
        [TestCase(30, 20, 50)]
        [TestCase(70, 30, 100)]
        [TestCase(100, 10, 110)]
        [Ignore("Its not prepared well")]
        [Author ("Author 1")]
        public void addTest1020(int x, int y, int expectedOutput)
        {
            // Arrange
            NUnitTestingDemo.NumericFunctions numericFunctions = new NumericFunctions();
            // Act
            int res = numericFunctions.add(x, y);
            // Assert
            Assert.That(expectedOutput, Is.EqualTo(res));
            Assert.AreEqual(expectedOutput, res);
        }

        [Test, Combinatorial]
        [Description("This is used for testing add method")]
        public void TestingAMethodWhichCallsOtherMethod(
            [Values(1,2,3)] int x)

        //public void TestingAMethodWhichCallsOtherMethod(
        //            [Values(1, 2, 3)] int x)
        {
            NUnitTestingDemo.NumericFunctions obj = new NumericFunctions();
            if (obj.CallingSomeotherMethod(x) > 10)
            {
                Assert.AreNotEqual(10, 1);
            }
            else
            {

                Assert.AreNotEqual(10, 1);
            }
        }




        //[Test]
        //public void addTest1020()
        //{
        //    // Arrange
        //    NUnitTestingDemo.NumericFunctions numericFunctions = new NumericFunctions();
        //    // Act
        //    int res = numericFunctions.add(10, 20);
        //    // Assert
        //    Assert.AreEqual(30, res);
        //}

        //[Test]
        //public void addTest3020()
        //{
        //    // Arrange
        //    NUnitTestingDemo.NumericFunctions numericFunctions = new NumericFunctions();
        //    // Act
        //    int res = numericFunctions.add(30, 20);
        //    // Assert
        //    Assert.AreEqual(50, res);
        //}

        //[Test]
        //public void addTest7010()
        //{
        //    // Arrange
        //    NUnitTestingDemo.NumericFunctions numericFunctions = new NumericFunctions();
        //    // Act
        //    int res = numericFunctions.add(70, 10);
        //    // Assert
        //    Assert.AreEqual(80, res);
        //}

    }
}
