using System;


namespace Triangle
{
    /*
     * This class computes area of the triangle using the universal formula, and don't need that triangle
     * been right. It allows not to make checks for rightness. In other hand class don't check that
     * triangle with such sides existst, so it believes that user is right.
     */
    public class ArbitraryTriangle
    {
        private double side1, side2, side3;
        public ArbitraryTriangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        /*
         * Compute area using Heron's formula. For details see http://mathworld.wolfram.com/HeronsFormula.html 
         */
        public double triangleArea()
        {
            double semiperimeter = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));

            return area;
        }
    }
}
