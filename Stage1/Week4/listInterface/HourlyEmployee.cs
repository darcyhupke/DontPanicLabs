using System;

namespace listInterface
{
    class HourlyEmployee : Employee, IGetBonus
    {
        //Properties
        public double hourlyRate
        { get; set; }

        public HourlyEmployee() : base() //default contructor
        {
            hourlyRate = 0.0;
        }

        public HourlyEmployee(string newLastName, string newFirstName, string newEmployeeType, double newHourlyRate) : base (newLastName, newFirstName, newEmployeeType) //constructor
        {
            hourlyRate = newHourlyRate;
        }

        //Interface method
        public double GetBonus()
        {
            return hourlyRate * 80;
        } 

        public override string ToString()
        {
            return base.ToString() + " | Hourly rate: $" + hourlyRate + " | Bonus: $" + GetBonus();
        }

    }//end class 
}//end namespace 