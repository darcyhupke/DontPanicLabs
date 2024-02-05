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
            employeeList.Add(new Employee ("Smith", "Hailey", "H"));

            //Add some hourly employees to the list for testing
            employeeList.Add(new HourlyEmployee ("Jones", "Cooper", "H", 17.35));
            employeeList.Add(new HourlyEmployee ("Hupke", "Dave", "H", 42.53));

            //Add salary employees to the list for testing
            employeeList.Add(new SalaryEmployee ("Ness", "Betty", "S", 75000));
            employeeList.Add(new SalaryEmployee ("Hupke", "Freddy", "S", 150000));

            //Print the list
            foreach (Employee anEmployee in employeeList)
            {
                Console.WriteLine(anEmployee);
            }

            //Reading (finding) an employee in the list
            Console.WriteLine("");
            Console.WriteLine("Lets find an employee in the list.");
            Console.WriteLine("Enter employee last name: ");
            string findName = Console.ReadLine();            
            bool empFound = false;

            foreach (Employee anEmployee in employeeList)
            {
                if (anEmployee.lastName == findName)
                {
                    Console.WriteLine(anEmployee);
                    empFound = true;
                }
            }
            if(!(empFound))
            {
                Console.WriteLine("Employee not found.");
            }

            //***********************************************************************
            //Creating (adding) an employee to the list
            //***********************************************************************
            Console.WriteLine("");
            Console.WriteLine("Add a new employee.");
            Console.WriteLine("Enter Last Name: ");
            string addLastName = Console.ReadLine();
            Console.WriteLine("Enter First Name: ");
            string addFirstName = Console.ReadLine();
            Console.WriteLine("Enter Employee Type (S = Salary | H = Hourly): ");
            string addEmpType = Console.ReadLine();

            switch (addEmpType)
            {
                case "S":
                case "s":
                    Console.WriteLine("Enter Annual Salary: ");
                    double addAnnualSalary = Convert.ToDouble(Console.ReadLine());
                    employeeList.Add(new SalaryEmployee(addLastName, addFirstName, addEmpType, addAnnualSalary));
                    Console.WriteLine("Salary Employee Added.");
                break;
                case "H":
                case "h":
                    Console.WriteLine("Enter Hourly Pay Rate: ");
                    double addHourlyRate = Convert.ToDouble(Console.ReadLine());
                    employeeList.Add(new HourlyEmployee(addLastName, addFirstName, addEmpType, addHourlyRate));
                    Console.WriteLine("Hourly Employee Added.");
                break;
                default:
                    Console.WriteLine("Invalid Employee Type. Nothing was added, try again!");
                break;
            }

            //print list after adding employee.
            foreach (Employee anEmployee in employeeList)
                Console.WriteLine(anEmployee);



            //************************************************************************************
            //Deleting an employee from the list
            //************************************************************************************
            Console.WriteLine("");
            Console.WriteLine("Delete an Employee.");
            Console.WriteLine("Enter Last Name: ");
            string delLastName = Console.ReadLine();
            Console.WriteLine("Enter First Name: ");
            string delFirstName = Console.ReadLine();
            empFound = false;

            for (int index = 0; index < employeeList.Count; index++)
            {
                if ((employeeList[index].lastName == delLastName) && (employeeList[index].firstName == delFirstName))
                {
                    employeeList.RemoveAt(index);
                    empFound = true;
                }
            }
            if (empFound)
                Console.WriteLine(delLastName + ", " + delFirstName + " has been deleted.");
            else
                Console.WriteLine("Employee not found. Please try again.");
            
            //print list after deleting employee.
            foreach(Employee anEmployee in employeeList)
                Console.WriteLine(anEmployee);
            

            //****************************************************************************************
            //Updating an existing employee's pay amount in the list
            //****************************************************************************************
            Console.WriteLine("");
            Console.WriteLine("Update an Employee.");
            Console.WriteLine("Enter Last Name: ");
            string updLastName = Console.ReadLine();
            Console.WriteLine("Enter First Name: ");
            string updFirstName = Console.ReadLine();
            empFound = false;

            for (int index = 0; index < employeeList.Count; index++)
            {
                if ((employeeList[index].lastName == updLastName) && (employeeList[index].firstName == updFirstName))
                {
                    Console.WriteLine("Please enter new amount: ");
                    double newAmount = Convert.ToDouble(Console.ReadLine());
                    employeeList[index].SetRate(newAmount);
                    empFound = true;
                }
            }
            if (empFound)
            {
                Console.WriteLine("Employee was updated.");
                Console.WriteLine("");
            }
            else
            {                
                Console.WriteLine("Employee not found, nothing was updated.");
                Console.WriteLine("");
            }

            //print list after updating an employee
            foreach (Employee anEmployee in employeeList)
                Console.WriteLine(anEmployee);


            //*******************************************************************************************
            //save the list to a text file.
            //*******************************************************************************************       
            string fileName = "employee.txt";

            try
            {
                //if file exists, delete it
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                //Create the file
                using(StreamWriter fileStr = File.CreateText(fileName))
                {                    
                    foreach (Employee anEmployee in employeeList)
                        fileStr.WriteLine(anEmployee);
                 
                }
                Console.WriteLine("");
                Console.WriteLine("Employee list has been saved to employee.txt");
                Console.WriteLine("");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }//end Main
    }//end class
}//end namespace