using System;

namespace listInterface
{
    class Employee
    {
        //Properties
        public string lastName
        { get; set; }

        public string firstName
        { get; set; }

        public string employeeType
        { get; set; }

        public Employee() //default contructor
        {
            lastName = "";
            firstName = "";
            employeeType = "";
        }

        public Employee(string newLastName, string newFirstName, string newEmployeeType) //constructor
        {
            lastName = newLastName;
            firstName = newFirstName;
            employeeType = newEmployeeType;
        }

        public override string ToString()
        {
            return "Employee: " + lastName + "," + firstName + " | Type: " + employeeType;
        }
        
    }//end class Employee
}//end namespace listInterface