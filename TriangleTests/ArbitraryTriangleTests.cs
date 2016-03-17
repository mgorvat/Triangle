using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Triangle;

namespace TriangleTests
{
    [TestClass]
    public class ArbitraryTriangleTests
    {
        const double eps = 0.000001;
        [TestMethod]
        public void testAreaComputation()
        {
            double[,] triangles = 
            {
                {4.0, 3.0, 5.0},
                {5.0, 13.0, 12.0},
                {8.0, 17.0, 15.0}
            };
            double[] answers = { 6.0, 30.0, 60.0 };

            for (int i = 0; i < triangles.GetLength(0); i++)
            {
                ArbitraryTriangle triangle = new ArbitraryTriangle(triangles[i, 0], triangles[i, 1], triangles[i, 2]);
                bool isEqual = Math.Abs(answers[i] - triangle.triangleArea()) < eps;
                Assert.IsTrue(isEqual);
            }
        }
    }
}
