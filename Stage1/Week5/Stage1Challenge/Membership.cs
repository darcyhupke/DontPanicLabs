using System;

namespace listMemberships
{
    abstract class Membership
    {
        //Properties
        public int memberID
        { get; set; }

        public string memberType
        { get; set; }

        public string memberEmail
        { get; set; }

        public double memberAnnualFee
        { get; set; }

        public double memberPurchaseBalance
        { get; set; }

        public Membership() //default contructor
        {
            memberID = 0;
            memberType = "";
            memberEmail = "";
            memberAnnualFee = 0.0;
            memberPurchaseBalance = 0.0;
        }

        public Membership(int newMemberID, string newMemberType, string newMemberEmail, double newAnnualFee, double newPurchaseBalance)
        {
            memberID = newMemberID;
            memberType = newMemberType;
            memberEmail = newMemberEmail;
            memberAnnualFee = newAnnualFee;
            memberPurchaseBalance = newPurchaseBalance;
        }

        public abstract void CashBack (double cashBackPercent);

        public void Purchase(double purchaseAmount)
        {
            memberPurchaseBalance = memberPurchaseBalance + purchaseAmount;
        }

         public void PurchaseReturn(double returnAmount)
        {
            memberPurchaseBalance = memberPurchaseBalance - returnAmount;
        }

        public override string ToString()
        {
            return "\nMember ID: " + memberID +  "\nMembership Type: " + memberType + "\nEmail Contact: " + memberEmail +"\nAnnual Cost: $" + memberAnnualFee + "\nAnnual Purchase Amount: $" + memberPurchaseBalance;
        }
    }
}//end namespace