using System;
using System.Collections.Generic; //needed for lists

namespace listInterface
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a list of Employees
            List<Employee> employeeList = new List<Employee>();

            //Add some employees to the list to test
            employeeList.Add(new Employee ("Hupke", "Darcy", "S"));
            employeeList.Add(new Employee ("Hupke", "Hailey", "H"));

            //Add some hourly employees to the list for testing
            employeeList.Add(new HourlyEmployee ("Hupke", "Cooper", "H", 17.35));
            employeeList.Add(new HourlyEmployee ("Hupke", "Dave", "H", 42.53));

            //Add salary employees to the list for testing
            employeeList.Add(new SalaryEmployee ("Hupke", "Betty", "S", 75000));
            employeeList.Add(new SalaryEmployee ("Hupke", "Freddy", "S", 150000));

            //Print the list
            foreach (Employee anEmployee in employeeList)
            {
                Console.WriteLine(anEmployee);
            }
            
        }//end Main
    }//end class
}//end namespace