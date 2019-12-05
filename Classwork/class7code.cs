using System;
using System.Collections.Generic;
using System.Text;

namespace inclassweek6
{
    class Movie
    {
        private string title;
        private string director;
        private int year;
        private int rating;

        
        public Movie(string title, string director, int year)
        {
            this.title = title;
            this.director = director;
            this.year = year;
            
        }
        public Movie(string title, int rating, string director)
        {
            this.title = title;
            this.rating = rating;
            this.director = director;
        }
        public Movie(string title)
        {
            this.title = title;            
        }
        
        public void Display()
        {
            Console.WriteLine("{0} directed by {1} released in {2}\n" , title, director, year);
            
        }
    




    }
}
