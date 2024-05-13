using FindArea.Library.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindArea.Library.Algo
{
    public class Triangle : TypeFigure
    {
        public double firstSide {  get; set; }
        public double secondSide { get; set; }
        public double thirdSide { get; set; }

        public Triangle(double firstside, double secondside, double thirdside)
        {
            firstSide = firstside;
            secondSide = secondside;
            thirdSide = thirdside;
        }
        public override double GetArea()
        {
            double semi = (firstSide + secondSide + thirdSide) / 2;
            double s= Math.Sqrt(semi * (semi - firstSide) * (semi - secondSide) * (semi - thirdSide));
          

            return Math.Round(s, 2);
        }
        public bool IsRightTriangle()
        {
            double firstSide2 = firstSide * firstSide;
            double secondSide2=secondSide * secondSide;
            double thirdSide2 = thirdSide * thirdSide;
            if (thirdSide2==firstSide2+secondSide2)
            {
                return true;
            }
            return false;
        }
    }
}
