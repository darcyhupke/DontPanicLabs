/*
Requirements/User stories:

Each employee will have a last name, first name and employee type (hourly or salary).
    An hourly employee will have an hourly rate. 
    A salary employee will have an annual salary.
Bonuses are calculated as followed:
    If not hourly or salary, the bonus is 0.
    Hourly, the bonus is two weeks pay (40 hours per week)
    Salary, the bonus is 10%
You want a menu that will provide you the options of doing the following:
    L - Load the single text file into the program.  The text file stores four lines for each 
        employee including last name, first name, employee type and hourly rate or salary 
        (depending on employee type - H or S)
    S - Store the current employee information in the text file
    C - Add an employee
    R - Print a list of all the employees including their calculated bonus,
    U - Update information for an employee,
    D - Delete an employee
    Q - Quit the program
Class design will include encapsulation, inheritance, and polymorphism.  Classes will include:
    Employee (last name, first name, employee type; constructors, calculate bonus, toString)
    HourlyEmployee (hourly rate; constructors, calculate bonus, toString)
    SalaryEmployee (annual salary; constructors, calculate bonus, toString
Be sure to follow best programming practices (no code smell!)
*/

using System;

namespace employeeAPP
{
    class Employee
    {
        public string ELastName
        { get; set; }

        public string EFirstName
        { get; set; }

        public string EType
        { get; set; }

        // default constructor when no values are being passed.
        public Employee ()
        {
            ELastName = null;
            EFirstName = null;
            EType = null;
        }

        // constructor for when values are passed
        public Employee (string newLastName, string newFirstName, string newType)
        {
            ELastName = newLastName;
            EFirstName = newFirstName;
            EType = newType;
        }
        
        // Polymorphism Method to pass bonus value. 
        public virtual float bonusAmount()
        {
            return 0;
        }

        //This overrides ToStrig so an abject can be printed out with a WriteLine
        public override string ToString()
        {
            return "Last Name: " + ELastName + "     First Name: " + EFirstName + "     Pay Type: " + EType + "     Bonus Amount: " + bonusAmount();
        }

    }

}