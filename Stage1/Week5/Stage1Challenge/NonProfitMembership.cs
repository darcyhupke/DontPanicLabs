using System;

namespace listMemberships
{
    class NonProfitMembership : Membership 
    {
        public string nonProfitType 
        { get; set; }
        

        public NonProfitMembership() : base()
        {
            nonProfitType = "";
        }

        public NonProfitMembership(int newMemberID, string newMemberType, string newMemberEmail, double newAnnualFee, double newPurchaseBalance, string newNonProfitType) : base(newMemberID, newMemberType, newMemberEmail, newAnnualFee, newPurchaseBalance)
        {
            nonProfitType = newNonProfitType;
        }

        public override void CashBack (double cashBackPercent) //implement abstact method
        {   
            double cashBackAmount;

            if (nonProfitType == "M" || nonProfitType == "E")            
                cashBackAmount = ((memberPurchaseBalance * cashBackPercent) * 2);
            else
                cashBackAmount = (memberPurchaseBalance * cashBackPercent);

            Console.WriteLine("Cash-back reward request for membership " + memberID + " in the amount of $" + cashBackAmount + " has been made!");
            memberPurchaseBalance = 0.0; 
        }

        

        public override string ToString()
        {
            return base.ToString() + "\nNon-Profit Type: " + nonProfitType;
        }
        
    }// class

}//end namespace
