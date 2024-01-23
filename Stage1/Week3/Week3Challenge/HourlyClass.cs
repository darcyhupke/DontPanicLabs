using System;

namespace employeeAPP
{
    class HourlyEmployee : Employee
    {
        //automatic property value
        public float HourlyRate
        { get; set; }

        //default constructor when no values are passed
        public HourlyEmployee () : base()
        {
            HourlyRate = 0;
        }

        //constructor with values passed
        public HourlyEmployee (string newLastName, string newFirstName, string newType, float newHourlyRate) : base (newLastName, newFirstName, newType)
        {            
            //float bonus = newHourlyRate * 80;
            HourlyRate = newHourlyRate;
        }

        public override float bonusAmount()
        {
            float bonus = HourlyRate * 80;
            return bonus;           
        }

        //This overrides ToString so an object can be printed
        public override string ToString() 
        {
            return base.ToString() + "     Hourly Rate = " + HourlyRate;
        }
    }
}
