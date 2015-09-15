using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic6
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle firstCircle = new Circle(-2, -3, 3); 
            Console.WriteLine("Point in circle: " + firstCircle.CheckPointInCircle(1,-3));
            Console.WriteLine(firstCircle.getObjectAsString());
            Complex firstComplexNumber = new Complex(1, 2);
            Complex secondComplexNumber = new Complex(1, 2);
            Complex sumComplexNumber = firstComplexNumber + secondComplexNumber;
            Console.WriteLine(sumComplexNumber.getObjectAsString());
        }

        

        

    }
}
