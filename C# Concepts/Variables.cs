using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Fundementals.C__Concepts
{
    public class Variables
    {
        public static void Run()
        {
            Console.WriteLine("Basic Types:");
            int age = 30;
            double salary = 1500.75;
            char grade = 'A';
            string name = "Sarah";
            bool isEmployed = true;

            Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary}, Grade: {grade}, Employed: {isEmployed}");

            Console.WriteLine("==========================================================================================");

            Console.WriteLine("Multiple Declarations:");


            int a = 5, b = 10, c = 15;
            Console.WriteLine(a + b + c);

            Console.WriteLine("==========================================================================================");

            Console.WriteLine("Default values:");
            int number;        // default: 0
            bool flag;         // default: false
            string text;       // default: null
            Console.WriteLine("Integer number is: default:0  falag is default false and string by defalt it is:null");

            Console.WriteLine("==========================================================================================");

            Console.WriteLine("Costants:");

            const double Pi = 3.14159;
            Console.WriteLine(" constant value not change");

            Console.WriteLine("==========================================================================================");
            Console.WriteLine(" Naming Convention");
            string firstName = "Ali";
            string lastName = "Hassan";
            Console.WriteLine("Full Name: " + firstName + " " + lastName);
            Console.WriteLine("==========================================================================================");



        }


    }
    }


