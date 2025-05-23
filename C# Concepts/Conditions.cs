using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundementals.C__Concepts
{
    internal class Conditions
    {
        public static void Run()
        {
            // 1. if statement
            int age = 20;
            if (age >= 18)
            {
                Console.WriteLine("You are an adult."); // runs because age is 20
            }

            // 2. if-else statement
            bool isLoggedIn = false;
            if (isLoggedIn)
            {
                Console.WriteLine("Welcome back!");
            }
            else
            {
                Console.WriteLine("Please log in."); // runs because isLoggedIn is false
            }

            // 3. if - else if - else
            int score = 85;
            if (score >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Grade: B"); // runs because score is 85
            }
            else
            {
                Console.WriteLine("Grade: F");
            }

            // 4. Ternary Operator
            int number = 5;
            string result = (number % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(result); // Output: Odd

            // 5. switch statement
            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday"); // runs
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
        }
    }
}
    
