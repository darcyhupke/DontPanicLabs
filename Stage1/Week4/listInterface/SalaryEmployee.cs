using System;

namespace listInterface
{
    class SalaryEmployee : Employee, IGetBonus
    {
        //Properties
        public double annualRate
        { get; set; }

        public SalaryEmployee() : base() //default contructor
        {
            annualRate = 0.0;
        }

        public SalaryEmployee(string newLastName, string newFirstName, string newEmployeeType, double newAnnualRate) : base (newLastName, newFirstName, newEmployeeType) //constructor
        {
            annualRate = newAnnualRate;
        }

        //Interface method
        public double GetBonus()
        {
            return annualRate * .1;
        } 

        public override string ToString()
        {
            return base.ToString() + " | Annual salary: $" + annualRate + " | Bonus: $" + GetBonus();
        }

    }//end class 
}//end namespace 