using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundementals.C__Concepts
{
    internal class MathOperators
    {

        public static void Run()
        {// Math Operators Examples
            int a = 10;
            int b = 3;

            // Addition
            int sum = a + b; // 13

            // Subtraction
            int difference = a - b; // 7

            // Multiplication
            int product = a * b; // 30

            // Division
            int quotient = a / b; // 3 (integer division)
            double preciseQuotient = (double)a / b; // 3.333...

            // Modulus (remainder)
            int remainder = a % b; // 1

            // Output results
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Precise Quotient: " + preciseQuotient);
            Console.WriteLine("Remainder: " + remainder);
        }
    }
}