using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
    
    public class Point{
        public double x, y;
        internal Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"{nameof(x)}: {x}, {nameof(y)} : {y}";
        }

        public static class Pointfactory
        {
            public static Point PolarPoint(double rho, double theta)
            {

                return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));

            }
            public static Point CartesianPoint(double x, double y)
            {
                return new Point(x, y);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var point = Point.Pointfactory.PolarPoint(2,3);
            Console.WriteLine(point);
            Console.ReadKey();
        }
    }
}
