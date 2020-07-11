using System;

namespace Numerical_methods
{
    public class SimpleIteration
    {

        public struct SimpleIterationResult
        {
            public double iterations;
            public double root;
        }

        public static SimpleIterationResult FindRoot(double initialGuess)
        {
            var firstIteration = initialGuess;
            var iteration = 0;

            for(iteration = 0; iteration<= 100; iteration++) 
            {
                double xNew;
                if (Math.Abs(initialGuess) <= 0.0)
                {
                    xNew = (2*Math.Pow(firstIteration, 2) + 3) / 5;
                } else
                {
                    xNew = Math.Sqrt((5 * firstIteration - 3) / 2);
                }

                if (Math.Abs(xNew - firstIteration) < 0.000001)
                {
                    break;
                }
         
                firstIteration = xNew;       
            }

            var result = new SimpleIterationResult
            {
                iterations = iteration+1,
                root = firstIteration
            };

            return result;

            
        }
    }
}
