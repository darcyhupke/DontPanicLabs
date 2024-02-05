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
            SetRate(newHourlyRate);
        }

        //Interface method
        public double GetBonus()
        {
            return hourlyRate * 80;
        } 

        //Interface method
        public override void SetRate(double newRate)
        {
            hourlyRate = newRate;
        }

        public override double GetRate()
        {
            return hourlyRate;
        }

        public override string ToString()
        {
            return base.ToString() + " | Hourly rate: $" + hourlyRate + " | Bonus: $" + GetBonus();
        }

    }//end class 
}//end namespace 