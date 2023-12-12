using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Figures
{
    public class Triangle : Figure
    {
        public double LengthA { get; set; }

        public double LengthB { get; set; }

        public double LengthC { get; set; }

        public Triangle(double lengthA, double lengthB, double lengthC)
        {
            LengthA = lengthA;
            LengthB = lengthB;
            LengthC = lengthC;
        }

        public override double CalculateArea()
        {
            double p = 0.5 * (LengthA + LengthB + LengthC);
            return Math.Sqrt(p * (p - LengthA) * (p - LengthB) * (p - LengthC));
        }

        public bool IsRight()
        {
            return (Math.Pow(LengthA, 2) == Math.Pow(LengthB, 2) + Math.Pow(LengthC, 2)) 
                || (Math.Pow(LengthB, 2) == Math.Pow(LengthC, 2) + Math.Pow(LengthA, 2)) 
                || (Math.Pow(LengthC, 2) == Math.Pow(LengthA, 2) + Math.Pow(LengthB, 2));
        }
    }
}
