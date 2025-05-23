using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundementals.C__Concepts
{
    internal class Function
    {
        public static void Run()
        {
            // Function without parameters or return value
            Greet();

            // Function with parameters, no return value
            SayHello("Layla");

            // Function with parameters and return value
            int result = Add(4, 6);
            Console.WriteLine("4 + 6 = " + result);

            // Function with default parameter
            Welcome();        // Default parameter
            Welcome("Fadi");  // Passing argument
        }

        // Function without parameters or return value
        static void Greet()
        {
            Console.WriteLine("Hello from Greet!");
        }

        // Function with parameters, no return value
        static void SayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        // Function with parameters and return value
        static int Add(int a, int b)
        {
            return a + b;
        }

        // Function with default parameter
        static void Welcome(string user = "Guest")
        {
            Console.WriteLine("Welcome, " + user);
        }
    }

}

