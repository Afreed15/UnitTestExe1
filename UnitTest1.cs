using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestExe
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSquare()
        {
            calLib.Calculation objs = new calLib.Calculation();
            double num1 = 12.21;
           
            double result = num1*num1;
            
            Assert.AreEqual(result, objs.Square(num1));
        }

        [TestMethod]
        public void TestCube()
        {
            calLib.Calculation objs = new calLib.Calculation();
            double num = 12.21;
            
            double result = num *num*num;

            Assert.AreEqual(result, objs.Cube(num));
        }
        [TestMethod]
        public void TestSquareroot()
        {
            calLib.Calculation objs = new calLib.Calculation();
            double num1 = 12.21;
            
            double result = 0.5*num1;

            Assert.AreEqual(result, objs.SquareRoot(num1));
        }
    }
}
