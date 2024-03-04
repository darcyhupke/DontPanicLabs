using System;

namespace listWhiskeys
{
    class Whiskey
    {
        //Automatic property variable. The get and set methods are being created too.
        public string WBrandName //Whiskey brand name
        { get; set; }

        public string WCategory //Whiskey Category
        { get; set; }

        public int WRating
        { get; set; }

        //This is the default constructor when no values are being passed
        public Whiskey()
        {
            WBrandName = null;
            WCategory = null;
            WRating = -1;
        }

        //This is the constructor when two values are passed.
        public Whiskey(string newBrandName, string newCategory, int newRating)
        {
            WBrandName = newBrandName;
            WCategory = newCategory;
            WRating = newRating;
        }

        //This overrides ToString so an object can be printed out with the WriteLine
        public override string ToString()
        {
            return "Whiskey Brand Name: " + WBrandName + "     Category: " + WCategory + "     Rating: " + WRating;
        }


    }
}