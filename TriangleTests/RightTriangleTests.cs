using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Triangle;

namespace TriangleTests
{
    [TestClass]
    public class RightTriangleTests
    {
        const double eps = 0.000001;
        [TestMethod]
        [ExpectedException(typeof(InvalidRightTriangleException), "Triangle is not right!")]
        public void testWrongTriangleCreation()
        {
            RightTriangle triangle = RightTriangle.generateTriangle(4.0, 5.0, 6.0);
        }

        [TestMethod]
        public void testTriangleCreation()
        {
            RightTriangle triangle1 = RightTriangle.generateTriangle(3.0, 4.0, 5.0);
            RightTriangle triangle2 = RightTriangle.generateTriangle(3.0, 5.0, 4.0);
            RightTriangle triangle3 = RightTriangle.generateTriangle(5.0, 4.0, 3.0);
        }

        [TestMethod]
        public void testAreaComputation()
        {
            RightTriangle triangle1 = RightTriangle.generateTriangle(3.0, 4.0, 5.0);
            RightTriangle triangle2 = RightTriangle.generateTriangle(3.0, 5.0, 4.0);
            RightTriangle triangle3 = RightTriangle.generateTriangle(5.0, 4.0, 3.0);

            bool triangle1And2Equal = Math.Abs(triangle1.triangleArea() - triangle2.triangleArea()) < eps;
            bool triangle2And3Equal = Math.Abs(triangle2.triangleArea() - triangle3.triangleArea()) < eps;
            bool triangleAreaCorrect = Math.Abs(triangle1.triangleArea() - 6.0) < eps;

            Assert.IsTrue(triangle1And2Equal);
            Assert.IsTrue(triangle2And3Equal);
            Assert.IsTrue(triangleAreaCorrect);
        }
    }
}
