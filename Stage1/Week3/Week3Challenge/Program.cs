using System;
using System.IO;
using System.Linq;

namespace employeeAPP
{
    class Program
    {
        static void Main(string[] args)
        {
/*
            //Test Employee class
            Employee employee1 = new Employee(); //test the first constructor for Employee
            Employee employee2 = new Employee("Hupke","Darcy","S"); //test constructor with data 
            Console.WriteLine(employee1);
            Console.WriteLine(employee2);
            Console.WriteLine(" ");

            //Test HourlyClass
            HourlyEmployee hourly1 = new HourlyEmployee();
            HourlyEmployee hourly2 = new HourlyEmployee("Jones","Tess","H",16.75F);
            Console.WriteLine(hourly1);
            Console.WriteLine(hourly2);
            Console.WriteLine(" ");

             //Test SalaryClass
            SalaryEmployee salary1 = new SalaryEmployee();
            SalaryEmployee salary2 = new SalaryEmployee("Jones","Dave","S",100000);
            Console.WriteLine(salary1);
            Console.WriteLine(salary2);
            Console.WriteLine(" ");
*/
            //Declare variables
            bool userChoice;
            string userChoiceString;
            const int rowSize = 25;
         
            Employee [] employeeArray = new Employee[rowSize];
            string fileName = "employee.txt";

            for (int indexRow = 0; indexRow < rowSize; indexRow++)
            {
                employeeArray[indexRow] = new Employee();
                
            }

            do
            {
                // Get valid input
                do
                {
                    //initialize variables
                    userChoice = false;

                    //user menu of options
                    Console.WriteLine("Employee Pay ");
                    Console.WriteLine("L: Load Employee file. ");
                    Console.WriteLine("S: Save the File. ");
                    Console.WriteLine("C: Add Employee Info. ");
                    Console.WriteLine("R: Display Employee List ");
                    Console.WriteLine("U: Update Employee Info. ");
                    Console.WriteLine("D: Delete an Employee. ");
                    Console.WriteLine("Q: Exit the program. ");
                    Console.WriteLine(" ");

                    //get user option (valid means it's on the menu)
                    userChoiceString = Console.ReadLine();

                    userChoice = (userChoiceString == "L" || userChoiceString == "l" ||
                                  userChoiceString == "S" || userChoiceString == "s" ||
                                  userChoiceString == "C" || userChoiceString == "c" ||
                                  userChoiceString == "R" || userChoiceString == "r" ||
                                  userChoiceString == "U" || userChoiceString == "u" ||
                                  userChoiceString == "D" || userChoiceString == "d" ||
                                  userChoiceString == "Q" || userChoiceString == "q");
                    
                    if (!userChoice)
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }

                } while (!userChoice);

                //If option is L or l - load the text file into the array
                if (userChoiceString == "L" || userChoiceString == "l")
                {
                    Console.WriteLine("In the L/l area");
                    int indexRow = 0;
                    using (StreamReader sr = File.OpenText(fileName))
                    {
                        string s = "";

                        Console.WriteLine("Here is your current employee file: ");
                        while ((s = sr.ReadLine()) != null)
                        {
                            //split each line on the comma into array called sides
                            string[] sides=s.Split(',');
                            if (sides[2] == "S") 
                            {
                                SalaryEmployee thisEmployee1 = new SalaryEmployee(sides[0], sides[1], sides[2], float.Parse(sides[3]));
                                employeeArray[indexRow] = thisEmployee1;
                            }
                                else                            
                                if (sides[2] == "H")
                                {
                                    HourlyEmployee thisEmployee2 = new HourlyEmployee(sides[0], sides[1], sides[2], float.Parse(sides[3]));
                                    employeeArray[indexRow] = thisEmployee2;
                                }
                                else
                                    {
                                        Employee thisEmployee3 = new Employee(sides[0], sides[1], sides[2]);
                                        employeeArray[indexRow] = thisEmployee3;
                                    }
                            
                                                                                   
                            Console.WriteLine(s);
                            indexRow++;
                        }
                        Console.WriteLine("");
                    }
                }

                //If option is S or s - store the array back to the text file
                else if (userChoiceString == "S" || userChoiceString == "s")
                {
                    Console.WriteLine("In the S/s area");
                    Console.WriteLine(" ");

                    float empWage = 0.0F;
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
                            for (int indexRow = 0; indexRow < rowSize; indexRow++)
                            {
                                if ((employeeArray[indexRow].ELastName) != null)
                                {
                                    string empLastName = employeeArray[indexRow].ELastName;
                                    string empFirstName = employeeArray[indexRow].EFirstName;
                                    string empType = employeeArray[indexRow].EType;
                                
                                    if ((employeeArray[indexRow].EType) == "S" || (employeeArray[indexRow].EType) == "s")
                                        {
                                            SalaryEmployee sEmployee = (SalaryEmployee)employeeArray[indexRow];
                                            empWage = sEmployee.SalaryAmount;
                                        }
                                    else
                                        if ((employeeArray[indexRow].EType) == "H" || (employeeArray[indexRow].EType) == "h")
                                            {
                                                HourlyEmployee hEmployee = (HourlyEmployee)employeeArray[indexRow];
                                                empWage = hEmployee.HourlyRate;
                                            }
                                
                                    fileStr.WriteLine(empLastName + "," + empFirstName + "," + empType + "," + empWage);
                                }
                                //fileStr.WriteLine(empLastName + "," + empFirstName + "," + empType + "," );
                            }
                            Console.WriteLine("Employee list has been saved to employee.txt.");
                            Console.WriteLine("");
                        }    
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }

                //If option is C or c - add an employee into the array
                else if (userChoiceString == "C" || userChoiceString == "c")
                {                    
                    Console.WriteLine("In the C/c area");
                    Console.WriteLine(" ");
                    Console.WriteLine("Please enter the following employee information:");
                    Console.WriteLine("Employee First name: ");
                    string addFirstName = Console.ReadLine();
                    Console.WriteLine("Employee Last name: ");
                    string addLastName = Console.ReadLine();
                    string addType;                    
                    float addWage = 0.0F;
                    bool typeChoice;
                                        
                    do
                    {
                        typeChoice = false;
                        
                        Console.WriteLine("Employee pay type (S for Salary : H for Hourly : O for Other): ");
                        addType = Console.ReadLine();
                                        
                        typeChoice = (addType == "S" || addType == "s" || 
                                      addType == "H" || addType == "h" ||
                                      addType == "O" || addType == "o");

                        if (!typeChoice)
                        {               
                            Console.WriteLine("Please enter a valid type.");
                        }
                            if (addType == "S" || addType == "s")
                            {
                                Console.WriteLine("Annual Salary: ");
                                addWage = float.Parse(Console.ReadLine());
                            }
                            else 
                                if (addType == "H" || addType =="h")
                                {
                                    Console.WriteLine("Hourly Wage: ");
                                    addWage = float.Parse(Console.ReadLine());
                                }
                    } while (!typeChoice);
                                                        
                    bool empAdded = false;

                    for ( int indexRow = 0; indexRow < rowSize; indexRow++)
                    {
                        if ((employeeArray[indexRow].ELastName) == null)
                        {
                            if (addType == "S" || addType == "s")
                                employeeArray[indexRow] = new SalaryEmployee(addLastName,addFirstName,addType,addWage);
                            else
                                if (addType == "H" || addType == "h")
                                    employeeArray[indexRow] = new HourlyEmployee(addLastName,addFirstName,addType,addWage);
                                else
                                    employeeArray[indexRow] = new Employee(addLastName,addFirstName,addType);
                            

                            indexRow = rowSize;
                            empAdded = true;
                        }
                    }
                    if (!empAdded)
                    {
                        Console.WriteLine("No room available!");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("Record has been added. Select R to display an updated list.");
                        Console.WriteLine(" ");
                    }
                }
                
                //If option is R or r - print the list of employees
                else if (userChoiceString == "R" || userChoiceString == "r")
                {
                    Console.WriteLine("In the R/r area");
                    Console.WriteLine(" ");

                    
                    for (int indexRow = 0; indexRow < rowSize; indexRow++)
                    {
                        //SalaryEmployee thisEmployee1 = new SalaryEmployee()
                        if ((employeeArray[indexRow].ELastName) != null)
                            Console.WriteLine(employeeArray[indexRow]);                            
                        else
                            Console.WriteLine("Index " + indexRow + " is available."); 
                    }
                    Console.WriteLine("");
                }

                //If option is U or u - update an employee
                else if (userChoiceString == "U" || userChoiceString == "u")
                {
                    Console.WriteLine("In the U/u area");
                    Console.WriteLine("");
                    Console.WriteLine("What employee whould you like to Update? ");
                    Console.WriteLine("First Name: ");
                    string chgFirstName = Console.ReadLine();
                    Console.WriteLine("Last Name: ");
                    string chgLastName = Console.ReadLine();
                    Console.WriteLine("Please enter the following fields: ");
                    Console.WriteLine("New First Name: ");
                    string chgFirstNameTo = Console.ReadLine(); 
                    Console.WriteLine("New Last Name: ");
                    string chgLastNameTo = Console.ReadLine();
                    float chgWageTo = 0.0F;
                    string chgType;
                    
                  
                    Console.WriteLine("");
                    bool foundUpdate = false;

                    for (int indexRow = 0; indexRow < rowSize; indexRow++)
                    {                     
                        if (((employeeArray[indexRow].EFirstName) == chgFirstName) &&
                             ((employeeArray[indexRow].ELastName) == chgLastName))
                            {
                                chgType = (employeeArray[indexRow].EType);
                                if ((employeeArray[indexRow].EType) == "S" || (employeeArray[indexRow].EType == "s"))
                                {                                    
                                    Console.WriteLine("New Salary Amount: ");
                                    chgWageTo = Single.Parse(Console.ReadLine());
                                    employeeArray[indexRow] = new SalaryEmployee(chgLastNameTo,chgFirstNameTo,chgType,chgWageTo);
                                }
                                else
                                    if ((employeeArray[indexRow].EType) == "H" || (employeeArray[indexRow].EType == "h"))
                                    {                                 
                                        Console.WriteLine("New Hourly Rate: ");
                                        chgWageTo = Single.Parse(Console.ReadLine());
                                        employeeArray[indexRow] = new HourlyEmployee(chgLastNameTo,chgFirstNameTo,chgType,chgWageTo);
                                    }
               
                            foundUpdate = true;
                            } 
                        if  (foundUpdate)   
                            break;
                    }
                    if(!foundUpdate)
                    {                        
                        Console.WriteLine("Employee not found!");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine(chgFirstName + " " + chgLastName + " has been updated. Select R to display an updated list.");
                        Console.WriteLine("");
                    }    
                }

                //If option is D or d - delete an employee
                else if (userChoiceString == "D" || userChoiceString == "d")
                {
                    Console.WriteLine("In the D/d area");
                    Console.WriteLine(" ");
                    Console.WriteLine("What employee whould you like to Delete? ");
                    Console.WriteLine("First Name: ");
                    string delFirstName = Console.ReadLine();
                    Console.WriteLine("Last Name: ");
                    string delLastName = Console.ReadLine();
                    bool foundDelete = false;

                    for (int indexRow = 0; indexRow < rowSize; indexRow++)
                    {
                        if (((employeeArray[indexRow].EFirstName) == delFirstName) &&
                             ((employeeArray[indexRow].ELastName) == delLastName))
                            {
                            employeeArray[indexRow] = new Employee();
                            
                                foundDelete = true;
                            } 
                        if  (foundDelete)   
                            break;
                    }
                    if(!foundDelete)
                        Console.WriteLine("Employee not found!");
                    else
                    {
                        Console.WriteLine(delFirstName + " " + delLastName + " has been deleted. Select R to display an updated list.");
                        Console.WriteLine("");
                    }
                }

                //If option is Q or q - exits the program
                else
                {
                    Console.WriteLine("Thank you!");
                }
            } while (!(userChoiceString == "Q") && !(userChoiceString == "q"));
            
        } //Main close
       
    } //class close
} //namespace close