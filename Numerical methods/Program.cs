using System;

namespace Numerical_methods
{
    class Program
    {
        static void Main(string[] args)
        {
           var root =  SimpleIteration.FindRoot(0.0);


           Console.WriteLine(root.root.ToString());
            Console.WriteLine(root.iterations);


           var secondRoot = SimpleIteration.FindRoot(2.0);


           Console.WriteLine(secondRoot.root.ToString());
            Console.WriteLine(secondRoot.iterations);


        }
    }
}
