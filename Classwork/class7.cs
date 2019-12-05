using System;
using System.Collections.Generic;
using System.Text;

namespace inclassweek6
{
    class MovieTest
    {
        static void Main(string[] args)
        {
            Movie myMovie = new Movie("Iron Man" , "Jon Favreau", 2008);
            Movie myFavoriteMovie = new Movie("Rudy", 5, "David Anspaugh");
            Movie myOtherMovie = new Movie("Scar Face");

            myMovie.Display();
            myFavoriteMovie.Display();
            myOtherMovie.Display();



        }                       

               
    }
}
