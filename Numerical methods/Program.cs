using Numerical_methods.starting_methods;
using System;

namespace Numerical_methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Bisection bisection = new Bisection();

            var result = bisection.Find(2,0);

            Console.WriteLine(result);

        }
    }
}
