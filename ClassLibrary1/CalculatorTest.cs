using NUnit.Framework;
using System;

namespace ClassLibrary1
{
    public class Class1
    {
        [Test]
        public void AddTest()
        {
            //Arrange
            double a=2, b=3;

            //Act
            double result = Calculator.Add(a, b);

            //Assert
            Assert.AreEqual(a + b, result);
        }

        [Test]
        public void DivisionTest()
        {
            //Arrange
            double a = 4, b = 4;

            //Act
            double result = Calculator.Divide(a, b);

            //Assert
            Assert.AreEqual(a / b, result);
        }

        [Test]
        public void DivisionTestByZero()
        {
            try
            {
                //Arrange
                double a = 6, b = 0;

                //Act
                double result = Calculator.Divide(a, b);
            }
            catch (DivideByZeroException)
            {
                Assert.Pass("Expected Divide by zero exception cought");
            }
            catch (Exception)
            {
                Assert.Fail("Wrong exception cought");
            }
        }

        [Test]
        public void DivisionTestDivideZero()
        {
            //Arrange
            double a = 0, b = 4;

            //Act
            double result = Calculator.Divide(a, b);
            Console.WriteLine(result);

            //Assert
            Assert.AreEqual(a / b, result);
        }
    }
}
