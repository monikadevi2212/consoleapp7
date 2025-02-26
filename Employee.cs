namespace EmployeeNamespace
{
    // Employee class definition
    public class Employee(int id, string firstName, string lastName)
    {
        // Properties for Id, FirstName, and LastName
        public int Id { get; set; } = id;            // Initialize Id property
        public string FirstName { get; set; } = firstName ?? throw new ArgumentNullException(nameof(firstName)); // Initialize FirstName property
        public string LastName { get; set; } = lastName ?? throw new ArgumentNullException(nameof(lastName));   // Initialize LastName property

        // Overload the equality operator (==)
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both employees have the same Id
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;  // Both are null, so they are considered equal
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false; // One is null, the other is not, so they are not equal

            return emp1.Id == emp2.Id; // Compare the Id property of both Employee objects
        }

        // Overload the inequality operator (!=)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Simply negate the result of the equality operator
            return !(emp1 == emp2); // If they are not equal, return true
        }

        // Override the Equals method to make comparison work properly for object comparisons
        public override bool Equals(object obj)
        {
            // If the object is null or not of type Employee, return false
            if (obj == null || !(obj is Employee))
                return false;

            // Compare Id properties of the current object and the provided object
            Employee other = obj as Employee;
            return this.Id == other.Id;
        }

        // Override the GetHashCode method to ensure consistency with Equals method
        public override int GetHashCode()
        {
            return Id.GetHashCode(); // Hash code is based on the Id property
        }
    }
}


 