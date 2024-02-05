using System;

namespace listMemberships
{
    class ExecMembership : Membership, ISpecialOffer
    {
        
        public ExecMembership(int newMemberID, string newMemberType, string newMemberEmail, double newAnnualFee, double newPurchaseBalance) : base(newMemberID, newMemberType, newMemberEmail, newAnnualFee, newPurchaseBalance)
        {
           
        }

        public override void CashBack (double cashBackPercent) //implement abstact method
        {    
            double cashBackAmount;

            if (memberPurchaseBalance > 1000)
                cashBackPercent = cashBackPercent + .02;            
            //    cashBackAmount = ((memberPurchaseBalance * cashBackPercent) * 2);
            //else
                cashBackAmount = (memberPurchaseBalance * cashBackPercent);
                      
            Console.WriteLine("Cash-back reward request for membership " + memberID + " in the amount of $" + cashBackAmount + " has been made!");
            memberPurchaseBalance = 0.0;
        }

        public double GetSpecialOffer() //Interface Method
        {
            return memberAnnualFee * .50;
        }

        public override string ToString()
        {
            return base.ToString() + "\nYou qualify for a special offer on your Annual Membership Fee. " + "\nHere is your new offer: $" + GetSpecialOffer();
        }
        
    }// class

}//end namespace
