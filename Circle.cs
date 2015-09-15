using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic6
{
    /// <summary>
    ///  Class circle. Task 2
    /// </summary>
    class Circle
    {
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                try
                {
                    if (value < 0) {
                        throw new Exception("Bad radius. Radius cant be less than zero");
                    }
                    else {
                        radius = value;
                        // Do nothing
                    }


                }
                catch (Exception setException)
                {
                    Console.WriteLine(setException.Message);
                }
            }
        }
        public double cordinateX { get; set; }
        public double cordinateY { get; set; }

        public Circle() { }
        public Circle(double x, double y, double radius)
        {
            cordinateX = x;
            cordinateY = y;
            Radius = radius;
        }

        public double GetCircumference() 
        {
            return 2 * Math.PI * Radius;
        }

        public double GetCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public Circle GetNewCircle()
        {
            return GetNewCircle(cordinateX, cordinateY, Radius);
        }

        public Circle GetNewCircle(double x, double y, double radius)
        {
            Circle newCircle = new Circle();
            newCircle.cordinateX = x;
            newCircle.cordinateY = y;
            newCircle.Radius = radius;
            return newCircle;
        }

        public bool CheckPointInCircle(double x,double y)
        {

            double a = Math.Abs(cordinateX-x);
            double b = Math.Abs(cordinateY - y);
            double hypot = Math.Sqrt(a*a + b*b);

            return ((hypot<=Radius)?true:false);
        }

        public String getObjectAsString() {
            String result = "Radius: " + Radius + "\nX: " + cordinateX + "\nY: " + cordinateY;
            return result;
        }
    }
}
