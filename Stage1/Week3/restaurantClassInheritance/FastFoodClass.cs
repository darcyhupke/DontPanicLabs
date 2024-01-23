using System;

namespace restaurantAPP
{
    class FastFood : Restaurant
    {    
        // This is the automatic property variable.  The get and set methods are being created too.
        public bool DDriveThru  // property
            { get; set; }
        

        // This is the default constructor when no values are being passed.
        public FastFood () : base(null, -1)  // use the parent constructor for the name and rating
        {
            DDriveThru = false;
        }

        // This is the constructor when three values are passed.
        public FastFood (string newRestaurant, int newRating, bool newHasDriveThru) : base(newRestaurant,newRating) // use the parent constructor for the name and rating
        {
            DDriveThru = newHasDriveThru;
        }
        
        // This overrides ToString so an object can be printed out with the WriteLine.

        public override string ToString()
        {
            return base.ToString() + " Is there a Drive Thru: " + DDriveThru;
        }

    }// class DriveThru
}// namespace restaurantAPP 