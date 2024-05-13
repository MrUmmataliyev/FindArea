using FindArea.Library.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindArea.Library.Algo
{
    public class Rectangle : TypeFigure
    {
        public double width { get; set; }
        public double height { get; set; }
        public Rectangle(double Width, double Height)
        {
            width = Width;
            height = Height;
        }
        public override double GetArea()
        {
            double area = width*height;
            if (area % 1 != 0)
            {
                return Math.Round(area,2);
            }
            return area;
        }
    }
}
