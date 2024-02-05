using System;

namespace listMemberships
{
    class RegularMembership : Membership, ISpecialOffer
    {
        //public double cashBack 
        //{ get; set; }

        //public RegularMembership() : base()q
        
        //{
        //    cashBack = 0.0;
        //}

        public RegularMembership(int newMemberID, string newMemberType, string newMemberEmail, double newAnnualFee, double newPurchaseBalance) : base(newMemberID, newMemberType, newMemberEmail, newAnnualFee, newPurchaseBalance)
        {
            //cashBack = newCashBack;
        }

        public override void CashBack (double cashBackPercent) //implement abstact method
        {            
            double cashBackAmount = memberPurchaseBalance * cashBackPercent;
            Console.WriteLine("Cash-back reward request for membership " + memberID + " in the amount of $" + cashBackAmount + " has been made!");
            memberPurchaseBalance = 0.0;
        }

        public double GetSpecialOffer() //Interface Method
        {
            return memberAnnualFee * .75;
        }

        public override string ToString()
        {
            return base.ToString() + "\nYou qualify for a special offer on your Annual Membership Fee. " + "\nHere is your new offer: $" + GetSpecialOffer();
        }
        
    }// class

}//end namespace
