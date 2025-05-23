using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundementals.C__Concepts
{
    delegate void Notify(string message);

    class program
    {
        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void LogMessage(string message)
        {
            Console.WriteLine("Log: " + message);
        }

        static void Main()
        {
            // Create delegate instance pointing to DisplayMessage
            Notify notify = DisplayMessage;

            // Add LogMessage to delegate invocation list
            notify += LogMessage;

            // Call delegate (calls both methods)
            notify("Delegate example!");

            // Output:
            // Delegate example!
            // Log: Delegate example!
        }
    }
}
