using System;

namespace employeeAPP
{
    class SalaryEmployee : Employee
    {
        //automatic property value
        public float SalaryAmount
        { get; set; }

        //default constructor when no values are passed
        public SalaryEmployee () : base()
        {
            SalaryAmount = 0;
        }

        //constructor with values passed
        public SalaryEmployee (string newLastName, string newFirstName, string newType, float newSalaryAmount) : base (newLastName, newFirstName, newType)
        {
            SalaryAmount = newSalaryAmount;
        }

        public override float bonusAmount()
        {
            float bonus = (float)(SalaryAmount * .10);
            return bonus;           
        }
        //This overrides ToString so an object can be printed
        public override string ToString() 
        {
            return base.ToString() + "    Salary Amount = " + SalaryAmount;
        }
    }
}
