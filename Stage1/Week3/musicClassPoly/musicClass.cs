using System;

namespace musicAPP
{
    class Music
    {
       
        // This is the automatic property variable.  The get and set methods are being created too.
        public string SongArtist 
            { get; set; }
        
        public string SongTitle 
            { get; set; } 

        public string SongMedia 
            { get; set; } 


        // This is the default constructor when no values are being passed.
        public Music ()
        {
            SongTitle = null;
            SongArtist = null;
            SongMedia = null;
        }

        // This is the constructor when two values are passed. Constructors can have the method be the same name and has to be the same as 
        public Music(string newSongTitle, string newSongArtist, string newSongMedia)
        {
            SongArtist = newSongArtist;
            SongTitle = newSongTitle;
            SongMedia = newSongMedia;

        }
        
        // The following method demonstrates polymorphism.  This is the parent class method
        public virtual bool paymentRequired()
        {
            return true;
        }

        // This overrides ToString so an object can be printed out with the WriteLine.
        public override string ToString()
        {
            return "Title: " + SongTitle + "     Artist: " + SongArtist + "     Media: " + SongMedia + "    Must pay to listen: " + paymentRequired();
        }

    }//class Music
}//namespace musicAPP