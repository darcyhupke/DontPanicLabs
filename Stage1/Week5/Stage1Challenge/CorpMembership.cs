using System;

namespace listMemberships
{
    class CorpMembership : Membership 
    {
        //public string nonProfitType 
        //{ get; set; }

        //public CorpMembership() : base()
        //{
        //    nonProfitType = "";
        //}

        public CorpMembership(int newMemberID, string newMemberType, string newMemberEmail, double newAnnualFee, double newPurchaseBalance) : base(newMemberID, newMemberType, newMemberEmail, newAnnualFee, newPurchaseBalance)
        {
            //nonProfitType = newNonProfitType;
        }

        public override void CashBack (double cashBackPercent) //implement abstact method
        {   
            double cashBackAmount = (memberPurchaseBalance * cashBackPercent);

            Console.WriteLine("Cash-back reward request for membership " + memberID + " in the amount of $" + cashBackAmount + " has been made!");
            memberPurchaseBalance = 0.0;
        }

        

        public override string ToString()
        {
            return base.ToString();
        }
        
    }// class

}//end namespace
