using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigure.Common;

namespace GeometricFigure
{
    public class Rectangle: Quadrangle
    {
        public Rectangle(Point startPoint, Point endPoint) : base(startPoint, new Point(startPoint.X, endPoint.Y), endPoint, new Point(endPoint.X, startPoint.Y))
        {

        }
    }
}
