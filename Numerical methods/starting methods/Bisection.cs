using System;

namespace Numerical_methods.starting_methods
{
    public class Bisection
    {
        private static double EPSILON = 0.000001;

        public double Find(double xPositive, double xNegative)
        {
            double x = 0;
            

            while(Math.Abs(xPositive - xNegative) > EPSILON)
            {
                x = (xPositive + xNegative) / 2;

                if (f(x) > 0)
                {
                    xPositive = x;
                } else
                {
                    xNegative = x;
                }
            }

            return x;
        }

        private double f(double x)
        {
            return x * x - 2;
        }
    }
}
