using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public abstract class Shape
    {
        public abstract double Area();
    }
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle ret = new Rectangle();
            ret.Width = 10;
            ret.Height = 12;
            Console.WriteLine(ret.Area());

            Circle crcl = new Circle();
            crcl.Radius = 5;
            Console.WriteLine(crcl.Area());
            Console.ReadKey();
        }
    }
}
