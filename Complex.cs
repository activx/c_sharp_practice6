using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic6
{


    class Complex
    {
        double re { get; set; }
        double im { get; set; }

        public Complex (double real, double im){
            re = real;
            this.im = im;
        }

        public static Complex operator + (Complex numberFirst, Complex numberSecond)
        {
            return new Complex(numberFirst.re + numberSecond.re, numberFirst.im + numberSecond.im);
        }

        public static Complex operator - (Complex numberFirst, Complex numberSecond)
        {
            return new Complex(numberFirst.re - numberSecond.re, numberFirst.im - numberSecond.im);
        }

        public String GetObjectAsString(){
            return  "(" + re + ";" + im + "i)" ;
        }

        
    }

}
