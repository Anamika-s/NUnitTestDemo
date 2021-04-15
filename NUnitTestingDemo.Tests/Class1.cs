//using NUnit.Framework;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Moq;

//namespace NUnitTestingDemo.Tests
//{
//    [Author("Anamika")]
//    [Author("Anamika", "anamika.sawhney22@gmail.com")]
//    [TestFixture]
//    public class NumericFunctionsTestClass
//    {
//        [Test]
       
//        public void addTestFor40()
//        {
//            // Arrange
//            NUnitTestingDemo.NumericFunctions obj = new NUnitTestingDemo.NumericFunctions();
//            // Act
//            int res = obj.add(10, 30);
//            // Assert
//            Assert.AreEqual(40, res);
//        }
//        [Test]
//        public void addTestFor60()
//        {
//            // Arrange
//            NUnitTestingDemo.NumericFunctions obj = new NUnitTestingDemo.NumericFunctions();
//            // Act
//            int res = obj.add(30, 30);
//            // Assert
//            Assert.AreEqual(60, res);
//        }


//        [TestCase(10,20, 30)]
//        [TestCase(40, 20, 60)]
//        [TestCase(60, 20, 80)]
//        [TestCase(20, 10, 30)]
//        [TestCase(20, 20, 40)]

//        public void addTest(int x, int y, int expectedOutput)
//        {
//            // Arrange

//            NUnitTestingDemo.NumericFunctions obj = new NUnitTestingDemo.NumericFunctions();
//            // Act
//            int res= obj.add(x, y);
//            // Assert
//            Assert.That(expectedOutput, Is.EqualTo(res));
//            Assert.That(expectedOutput == res);

//        }

//        [Test]
//        public void CheckForHR()
//        {
//            NUnitTestingDemo.NumericFunctions obj = new NumericFunctions();
//            Assert.AreNotEqual(20,obj.GetLeaves("HR"));
//        }

//        [Test, Combinatorial]
//        public void TestingAMethodWhichCallsOtherMethod(
//            [Values(1,2,3)] int x)
//        {
//            NUnitTestingDemo.NumericFunctions obj = new NumericFunctions();
//            if (obj.CallingSomeotherMethod(x) > 10)
//            {
//                Assert.AreNotEqual(10, 1);
//            }
//            else
//            {

//                Assert.AreNotEqual(10, 1);
//            }
//        }
        

//        [Test]
//        public void AddCistomerTest()
//        {
//            //create the object
//            // which function to by pass
//            Mock<TestProject.EMailClass> obj = new Mock<TestProject.EMailClass>();
//            // Setup the moq
//            obj.Setup(x => x.sendMail()).Returns(true);
//            TestProject.Customer customer = new TestProject.Customer();
//            bool isInserted = customer.AddCustomer(obj.Object);
//            Assert.AreEqual(isInserted, true);

//        }
//        //    TestProject.Customer obj = new TestProject.Customer();
//        //    Assert.That(obj.AddCustomer(), Is.True);
//        //}

//    }
//}
