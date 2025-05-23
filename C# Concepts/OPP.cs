using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundementals.C__Concepts
{
    using System;

    // Abstract class demonstrating Abstraction
    abstract class Shape
    {
        public abstract double Area();
    }

    // Concrete class inheriting Shape and implementing Area()
    class Circle : Shape
    {
        private double radius;  // Encapsulation (private field)

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }

    // Base class demonstrating Encapsulation and Inheritance
    class Animal
    {
        private string name;  // Encapsulation

        public Animal(string name)
        {
            this.name = name;
        }

        // Virtual method for Polymorphism
        public virtual void Speak()
        {
            Console.WriteLine($"{name} makes a sound.");
        }

        // Getter method for encapsulated field
        public string GetName()
        {
            return name;
        }
    }

    // Derived class overriding Speak() to demonstrate Polymorphism
    class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        public override void Speak()
        {
            Console.WriteLine($"{GetName()} barks: Woof!");
        }
    }

    class Program
    {
        static void Main()
        {
            // Abstraction & Encapsulation demo
            Shape circle = new Circle(5);
            Console.WriteLine("Circle area: " + circle.Area());

            // Inheritance demo
            Animal genericAnimal = new Animal("GenericAnimal");
            genericAnimal.Speak();

        }
    }
}