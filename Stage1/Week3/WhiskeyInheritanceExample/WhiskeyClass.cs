using System;

namespace whiskeyAPP
{
    class Whiskey
    {
        //Automatic property variable. The get and set methods are being created too.
        public string WName //Whiskey name
            { get; set; }

        public string WDistillery //Whiskey Distillery
            { get; set; }

        public int WRating
            { get; set; }

        //This is the default constructor when no values are being passed
        public Whiskey ()
        {
            WName = null;
            WDistillery = null;
            WRating = -1; 
        }

        //This is the constructore when two values are passed.
        public Whiskey (string newWhiskey, string newDistillery, int newRating)
        {
            WName = newWhiskey;
            WDistillery = newDistillery;
            WRating = newRating;
        }

        //This overrides ToString so an object can be printed out with the WriteLine
        public override string ToString()
        {
            return "Whiskey: " + WName + "     Distillery: " + WDistillery + "     Rating: " + WRating;
        }


    }
}