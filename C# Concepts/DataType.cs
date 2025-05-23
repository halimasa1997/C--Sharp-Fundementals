using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundementals.C__Concepts
{
    public class DataType
    {

        public static void Run()
        {
            Console.WriteLine("Integer Datatype::");


            byte age = 25;            // 0 to 255
            short year = 2025;        // -32,768 to 32,767
            int population = 1500000; // -2B to 2B (default for integers)
            long distance = 9876543210; // Very large numbers

            Console.WriteLine("==========================================================================================");

            Console.WriteLine("Floating point  types:");
            float price = 9.99f;        // 4 bytes, needs 'f' suffix
            double rate = 0.123456789;  // 8 bytes, more precise
            decimal amount = 1000.75m;  // 16 bytes, for money, use 'm
                                        // 
            Console.WriteLine("==========================================================================================");

            Console.WriteLine("Character and string:");
            char grade = 'A';                 // Single character
            string message = "Hello World!";  // Sequence of characters

            Console.WriteLine("==========================================================================================");
            Console.WriteLine("Boolean ::");

            bool isLoggedIn = false; // true or false









        }
    }
}
