using System;
using System.Collections.Generic;

namespace Classmate_example_for_class
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Classmate> classlist = new List<Classmate>
            {
                new Classmate("Bill", "Buffalo", "Buffalo Chicken Wings", "Football", 7),
                new Classmate("Stitch", "Hawaii", "All of it", "Finding his family", 626),
                new Classmate("Oliver","Wales", "Crepes","Playing the banjo",4)
            };

            foreach (Classmate classmate in classlist)
            {
                classmate.PrintInfo();
            }
        }
    }
}
