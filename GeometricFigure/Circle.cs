using GeometricFigure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    public class Circle : Ellipse
    {
        public double Radius { get; }
        public Point Center { get; }

        public Circle(double radius, Point center = default) : base(new Point(center.X - radius, center.Y - radius), new Point(center.X + radius, center.Y + radius))
        {
            Radius = radius;
            Center = center;
        }
    }
}
