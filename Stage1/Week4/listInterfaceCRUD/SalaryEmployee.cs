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
            SetRate(newAnnualRate);
        }

        //Interface method
        public double GetBonus()
        {
            return annualRate * .1;
        } 

        public override void SetRate(double newRate)
        {
            annualRate = newRate;
        }

        public override double GetRate()
        {
            return annualRate;
        }

        public override string ToString()
        {
            return base.ToString() + " | Annual salary: $" + annualRate + " | Bonus: $" + GetBonus();
        }

    }//end class 
}//end namespace 