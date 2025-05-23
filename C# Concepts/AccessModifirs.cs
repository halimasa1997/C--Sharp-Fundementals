using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundementals.C__Concepts
{
    internal class AccessModifirs
    {
        // Accessible only inside this class
        private string privateField = "Private";

        // Accessible inside this class and derived classes
        protected string protectedField = "Protected";

        // Accessible inside the same assembly
        internal string internalField = "Internal";

        // Accessible inside derived classes or in same assembly
        protected internal string protectedInternalField = "Protected Internal";

        // Accessible only in derived classes from the same assembly
        private protected string privateProtectedField = "Private Protected";

        // Accessible everywhere
        public string publicField = "Public";

        public void ShowAccess()
        {
            Console.WriteLine(privateField);
            Console.WriteLine(protectedField);
            Console.WriteLine(internalField);
            Console.WriteLine(protectedInternalField);
            Console.WriteLine(privateProtectedField);
            Console.WriteLine(publicField);
        }
    }

    class SubClass : AccessDemo
    {
        public void ShowInheritedAccess()
        {
            // Console.WriteLine(privateField); //  Not accessible
            Console.WriteLine(protectedField);
            Console.WriteLine(protectedInternalField);
            Console.WriteLine(privateProtectedField);  //  if in same assembly
            Console.WriteLine(publicField);
        }
    }

    class Program
    {
        static void Main()
        {
            AccessDemo demo = new AccessDemo();
            demo.ShowAccess();

            SubClass sub = new SubClass();
            sub.ShowInheritedAccess();

            Console.WriteLine(demo.publicField);
            Console.WriteLine(demo.internalField);     //  (same project)
                                                      
        }
    }

}
}
