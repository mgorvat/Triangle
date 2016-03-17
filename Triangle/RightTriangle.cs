using System;

namespace Triangle
{
    public class RightTriangle
    {
        /*
         * This class use floating point computations. Direct equality checking is not disirable due to
         * computation errors. Eps is using for checkng equality considering computation errors.
         * Instead of (a == b), class use (Math.Abs(a - b) < eps) construction.
         */
        const double eps = 0.000001;
        private double cathetus1, cathetus2, hypotenuse;
        private RightTriangle(double cathetus1, double cathetus2, double hypotenuse)
        {
            this.cathetus1 = cathetus1;
            this.cathetus2 = cathetus2;
            this.hypotenuse = hypotenuse;
        }

        /* Input sides' lengths can possibly not be lenghts of right triangle. This method ensures that
         * triangle is right and create the triangle, or generate the exception if it's not right. 
         * Order of sides can be arbitrary.   
         */
        public static RightTriangle generateTriangle(double side1, double side2, double side3)
        {
            RightTriangle result = null;
            if (Math.Abs(side1 * side1 + side2 * side2 - side3 * side3) < eps)
            {
                result = new RightTriangle(side1, side2, side3);
            }
            else
            {
                if (Math.Abs(side1 * side1 + side3 * side3 - side2 * side2) < eps)
                {
                    result = new RightTriangle(side1, side3, side2);
                }
                else
                {
                    if (Math.Abs(side2 * side2 + side3 * side3 - side1 * side1) < eps)
                    {
                        result = new RightTriangle(side2, side3, side1);
                    }
                    else
                    {
                        throw new InvalidRightTriangleException("Triangle is not right!");
                    }
                }
            }
            return result;
        }

        /*
         * Triangle area is half of catheti length multiplication.
         */
        public double triangleArea()
        {
            return this.cathetus1 * this.cathetus2 / 2;
        }
    }

    public class InvalidRightTriangleException : System.Exception
    {
        public InvalidRightTriangleException() : base() { }
        public InvalidRightTriangleException(string message) : base(message) { }
        public InvalidRightTriangleException(string message, System.Exception inner) : base(message, inner) { }

        protected InvalidRightTriangleException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }

    }
}
