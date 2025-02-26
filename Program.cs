
// See https://aka.ms/new-console-template for more information
using System;

namespace EmployeeNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two Employee objects with the same Id, different names
            Employee emp1 = new Employee(1, "John", "Doe");
            Employee emp2 = new Employee(1, "John", "Doe");

            // Compare the two Employee objects using overloaded == operator
            bool areEqual = emp1 == emp2;  // Calls the overloaded operator == to compare ids

            // Output the result of the comparison
            Console.WriteLine("Are emp1 and emp2 equal? " + areEqual); // Expected to print 'true' since the Ids are the same

            // Create a third Employee with a different Id
            Employee emp3 = new Employee(2, "Jane", "Smith");

            // Compare emp1 and emp3 using the overloaded != operator
            bool areNotEqual = emp1 != emp3; // Calls the overloaded operator != to compare ids

            // Output the result of the comparison
            Console.WriteLine("Are emp1 and emp3 not equal? " + areNotEqual); // Expected to print 'true' since the Ids are different
        }
    }
}

