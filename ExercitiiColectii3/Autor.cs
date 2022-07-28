using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercitiiColectii3
{
    internal class Autor
    {
        private string nume;
        private DateTime dataNasterii;
        private double rating;

        public Autor()
        {

        }

        public Autor(string nume, DateTime dataNasterii, double rating)
        {
            this.nume = nume;
            this.dataNasterii = dataNasterii;
            this.setRating(rating);
        }

        //nume
        public string getNume()
        {
            return this.nume;
        }
        public void setNume(string nume)
        {
            this.nume = nume;
        }

        //Data nasterii
        public DateTime getDataNasterii()
        {
            return this.dataNasterii;
        }
        
        public void setDataNasterii(DateTime dataNasterii)
        {
            this.dataNasterii = dataNasterii;
        }

        //Rating
        public double getRating()
        {
            return this.rating;
        }

        public void setRating(double rating)
        {
            if(rating >= 0 && rating <= 5)
            {
                this.rating = rating;
            }
            else
            {
                Console.Error.WriteLine("Rating-ul nu corespunde.");
            }
        }

       
    }
}
