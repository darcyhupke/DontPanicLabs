using System;

namespace listAbstractClass
{
    abstract class Employee //this is an abstract class so it can't be instantiated (objects of this type can't be created)
    {
        public string lastName //property
            { get; set; }
        
        public string firstName //property
            { get; set; }
        
        public string emplyeeType //property
            { get; set; }

        public Employee() //default constructor
        {
            lastName = "";
            firstName = "";
            emplyeeType= "";
        }

        public Employee(string newLastName, string newFirstName, string newEmployeeType) //another constructor
        {
            lastName = newLastName;
            firstName = newFirstName;
            emplyeeType = newEmployeeType;
        }

        public abstract double GetBonus(); //this is the abstract method that all children must implement

        public override string ToString()
        {
            return "Employee: " + lastName + "," + firstName + " | Type: " + emplyeeType;
        }

    }//end class Employee
}//end namespace listInterface