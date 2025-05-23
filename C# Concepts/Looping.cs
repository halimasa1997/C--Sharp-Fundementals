using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundementals.C__Concepts
{
    internal class Looping
    {
        public static void Run()
        {
            // For loop
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("For loop: " + i);
            }

            // While loop
            int a = 0;
            while (a < 3)
            {
                Console.WriteLine("While loop: " + a);
                a++;
            }

            // Do-While loop
            int b = 3;
            do
            {
                Console.WriteLine("Do-While loop: " + b);
                b++;
            } while (b < 3); // Executes once

            // Foreach loop
            string[] cars = { "BMW", "Toyota", "Honda" };
            foreach (string car in cars)
            {
                Console.WriteLine("Car: " + car);
            }
        }
    }
}
