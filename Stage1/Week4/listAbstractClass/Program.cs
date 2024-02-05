using System;
using System.Collections.Generic; //needed for Lists

namespace listAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of Employees
            List<Employee> employeeList = new List<Employee>();
            //Add an hourly employee
            employeeList.Add(new HourlyEmployee("Hupke", "Darcy", "H", 23.25));
            //Add a salary employee
            employeeList.Add(new SalaryEmployee("Hupke", "Dave", "S", 150000));

            //Create a list of Hourly Employees to test with
            List<HourlyEmployee> hourlyEmployeeList = new List<HourlyEmployee>();
            //Create a list of Salarly Employees to test with
            List<SalaryEmployee> salaryEmployeeList = new List<SalaryEmployee>();

            //add a couple of hourly employees to the hourly list to test
            hourlyEmployeeList.Add(new HourlyEmployee ("Hupke", "Cooper", "H", 17.20));
            hourlyEmployeeList.Add(new HourlyEmployee ("Hupke", "Hailey", "H", 19.45));

            //add a couple of salary employees to the salary list
            salaryEmployeeList.Add(new SalaryEmployee ("Jones", "Tess", "S", 74545));
            salaryEmployeeList.Add(new SalaryEmployee ("Ness", "Luke", "S", 98050));

            //Print the employee list
            Console.WriteLine("Employee list");
            foreach (Employee anEmployee in employeeList)
            {
                Console.WriteLine(anEmployee);
            }

            //Print the hourly list
            Console.WriteLine("Hourly list");
            foreach (HourlyEmployee anEmployee in hourlyEmployeeList)
            {
                Console.WriteLine(anEmployee);
            }

            //Print the salary list
            Console.WriteLine("Salary list");

            foreach (SalaryEmployee anEmployee in salaryEmployeeList)
            {
                Console.WriteLine(anEmployee);
            }

            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
        }   
    }//end class
}//end namspace