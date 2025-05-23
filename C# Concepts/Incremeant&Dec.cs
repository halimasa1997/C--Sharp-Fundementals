using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundementals.C__Concepts
{
    internal class Incremeant_Dec
    {
        public static void Run()
        {
            Console.WriteLine("Increment and decreament::");

            
            int x = 5;

            // Post-increment: returns value then adds 1
            Console.WriteLine("x++ = " + (x++)); // 5, then x becomes 6

            // Pre-increment: adds 1 then returns value
            Console.WriteLine("++x = " + (++x)); // 7

            // Post-decrement: returns value then subtracts 1
            Console.WriteLine("x-- = " + (x--)); // 7, then x becomes 6

            // Pre-decrement: subtracts 1 then returns value
            Console.WriteLine("--x = " + (--x)); // 5

        }
    }
}
