using FindArea.Library.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindArea.Library.Algo
{
    public class Circle : TypeFigure
    {
        public double radius { get; set; }
        public Circle(double Radius)
        {

            radius = Radius;

        }

        public override double GetArea()
        {
            double Area = Math.PI * radius *radius;
            return Math.Round(Area, 2);
        }
    }
}
