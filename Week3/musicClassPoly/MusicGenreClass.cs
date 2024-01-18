using System;

namespace musicAPP
{
    class MusicGenre : Music
    {        

        // This is the automatic property variable.  The get and set methods are being created too.
        public string GGenre  // property
            { get; set; }
        

        // This is the default constructor when no values are being passed.
        public MusicGenre () : base(null, null, null)  // use the parent constructor for the name and rating
        {
            GGenre = null;
        }

        // This is the constructor when three values are passed.
        public MusicGenre (string newSongTitle, string newSongArtist, string newSongMedia, string newSongGenre) : base(newSongTitle, newSongArtist, newSongMedia) // use the parent constructor for the name and rating
        {
            GGenre = newSongGenre;
        }
        
         // The following method demonstrates polymorphism.  This is the child class method that overrides the parent
        public override bool paymentRequired()
        {
            return false;
        }

        // This overrides ToString so an object can be printed out with the WriteLine.
        public override string ToString()
        {
            return base.ToString() + "     Genre: " + GGenre;
        }

    }// class MusicGenre
}// namespace musicAPP 