using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AreaOfTriangle;
namespace AreaTests
{
    [TestClass]
    public class AreaOfRightTriangleTest
    {
        [TestMethod]
        public void GoldPathTest()
        {
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;

            double actualRes = AreaOfRightTriangle.CalcArea(a, b, c);
            double expectedRes = 0.5 * a * b;

            Assert.AreEqual(expectedRes, actualRes, "Площадь вычислена не верна");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValueAllSidesLessThatZeroTest()
        {
            double a = -3.0;
            double b = -4.0;
            double c = -6.0;

            AreaOfRightTriangle.CalcArea(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValueOneSideLessThatZeroTest()
        {
            double a = 3.0;
            double b = 4.0;
            double c = -6.0;

            AreaOfRightTriangle.CalcArea(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValueAllSidesEqualsZeroTest()
        {
            double a = 0.0;
            double b = 0.0;
            double c = 0.0;

            AreaOfRightTriangle.CalcArea(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValueOneSideEqualsZeroTest()
        {
            double a = 3.0;
            double b = 0.0;
            double c = 6.0;

            AreaOfRightTriangle.CalcArea(a, b, c);
        }

        [TestMethod]
        public void IsRightRectangleTest()
        {
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;

            bool actualRes = AreaOfRightTriangle.IsRightTriangle(a, b, c);
            bool expectedRes = true;

            Assert.AreEqual(expectedRes, actualRes);
        }
    }
}
